using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Web;
using System.Xml.Linq;

namespace BFH.NetDS.WebServices.ControlStation {

	[ServiceContract]
	public class ControlStationService {

		public static readonly Uri Uri = new Uri("http://localhost:6789/");

		public HashSet<IPAddress> terminals { get; private set; }

		public ControlStationService() {

			this.terminals = new HashSet<IPAddress>();
		}

		private void rememberTerminal() {

			terminals.Add(IPAddress.Parse(((RemoteEndpointMessageProperty)OperationContext.Current.IncomingMessageProperties[RemoteEndpointMessageProperty.Name]).Address));
		}

		[OperationContract]
		[WebGet(UriTemplate = "employee", ResponseFormat = WebMessageFormat.Json)]
		public List<Employee> FetchEmployees() {

			rememberTerminal();

			using (var src = new DataSource(true))
				return (from p in src.document.Root.Elements("person")
								let l = p.Attribute("login").Value
								let n = p.Attribute("name").Value
								orderby l
								select new Employee(l, n)).ToList();
		}

		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "employee", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public Employee AddEmployee(Employee employee) {

			rememberTerminal();

			using (var src = new DataSource()) {
				if (src.document.Root.Elements("person").Any(p => p.Attribute("login").Value.Equals(employee.login, StringComparison.InvariantCultureIgnoreCase)))
					throw new ArgumentException("A person with this login exists already.");

				src.document.Root.Add(new XElement("person",
					new XAttribute("login", employee.login),
					new XAttribute("name", employee.name)));
			}

			return employee;
		}

		[OperationContract]
		[WebGet(UriTemplate = "employee/{login}", ResponseFormat = WebMessageFormat.Json)]
		public EmployeeTimeStamps FetchEmployeeTimeStamps(String login) {

			rememberTerminal();

			using (var src = new DataSource(true))
				return new EmployeeTimeStamps(login, from p in src.document.Root.Elements("person")
																						 where p.Attribute("login").Value.Equals(login, StringComparison.InvariantCultureIgnoreCase)
																						 from t in p.Elements("timeStamp")
																						 let d = t.Attribute("dateTime").Value
																						 orderby d
																						 select d);
		}

		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "employee/{login}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public EmployeeTimeStamps AddEmployeeTimeStamps(String login, EmployeeTimeStamps timeStamps) {

			rememberTerminal();

			using (var src = new DataSource())
				src.document.Root.Elements("person").Single(p => p.Attribute("login").Value.Equals(login, StringComparison.InvariantCultureIgnoreCase))
					.Add(timeStamps.timeStampsFormatted.Select(t => new XElement("timeStamp", new XAttribute("dateTime", t))));

			return FetchEmployeeTimeStamps(login);
		}

		public static WebServiceHost GetServiceHost() {

			var host = new WebServiceHost(typeof(ControlStationService), Uri);
			host.Open();
			return host;
		}
	}
}
