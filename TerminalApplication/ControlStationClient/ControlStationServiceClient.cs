using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace BFH.NetDS.WebServices.Terminal.ControlStationClient {

	public class ControlStationServiceClient {

		private string host;
		private int port;

		public ControlStationServiceClient(string host, int port) {

			this.host = host;
			this.port = port;
		}

		public async Task<List<Employee>> FetchEmployeesAsync() { return await ServiceGetAsync<List<Employee>>("employee"); }

		public List<Employee> FetchEmployees() { return Sync(FetchEmployeesAsync()); }

		public async Task<Employee> AddEmployeeAsync(Employee employee) { return await ServicePostAsync<Employee>("employee", employee); }

		public Employee AddEmployee(Employee employee) { return Sync(AddEmployeeAsync(employee)); }

		public async Task<EmployeeTimeStamps> FetchEmployeeTimeStampsAsync(String login) { return await ServiceGetAsync<EmployeeTimeStamps>(string.Format("employee/{0}", login)); }

		public EmployeeTimeStamps FetchEmployeeTimeStamps(String login) { return Sync(FetchEmployeeTimeStampsAsync(login)); }

		public async Task<EmployeeTimeStamps> AddEmployeeTimeStampsAsync(String login, EmployeeTimeStamps timeStamps) { return await ServicePostAsync<EmployeeTimeStamps>(string.Format("employee/{0}", login), timeStamps); }

		public EmployeeTimeStamps AddEmployeeTimeStamps(String login, EmployeeTimeStamps timeStamps) { return Sync(AddEmployeeTimeStampsAsync(login, timeStamps)); }

		private async Task<T> ServicePostAsync<T>(string path, T body) {

			var ser = new JavaScriptSerializer();

			var req = WebRequest.CreateHttp(string.Format("http://{0}:{1}/{2}", host, port, path));
			using (var stm = new StreamWriter(await req.GetRequestStreamAsync()))
				await stm.WriteAsync(ser.Serialize(body));

			var res = (HttpWebResponse)await req.GetResponseAsync();
			using (var stm = new StreamReader(res.GetResponseStream()))
				return ser.Deserialize<T>(await stm.ReadToEndAsync());
		}

		private async Task<T> ServiceGetAsync<T>(string path) {

			var ser = new JavaScriptSerializer();

			var req = WebRequest.CreateHttp(string.Format("http://{0}:{1}/{2}", host, port, path));
			var res = (HttpWebResponse)await req.GetResponseAsync();
			using (var stm = new StreamReader(res.GetResponseStream()))
				return ser.Deserialize<T>(await stm.ReadToEndAsync());
		}

		private T Sync<T>(Task<T> async) {

			async.Wait();
			return async.Result;
		}
	}
}
