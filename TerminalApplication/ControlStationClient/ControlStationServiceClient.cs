using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BFH.NetDS.WebServices.Terminal.ControlStationClient {

	public class ControlStationServiceClient {

		public static int Port = 6789;

		private string host;

		public ControlStationServiceClient(string host) {

			this.host = host;
		}

		public async Task<List<Employee>> FetchEmployeesAsync() { return await RequestServiceAsync<List<Employee>>("employees"); }

		public List<Employee> FetchEmployees() { return Sync(FetchEmployeesAsync()); }

		public async Task<Employee> AddEmployeeAsync(Employee employee) { return await InvokeServiceAsync<Employee, Employee>("POST", "employees", employee); }

		public Employee AddEmployee(Employee employee) { return Sync(AddEmployeeAsync(employee)); }

		public async Task<EmployeeTimeStamps> FetchEmployeeTimeStampsAsync(string login) { return await RequestServiceAsync<EmployeeTimeStamps>(string.Format("employees/{0}", login)); }

		public EmployeeTimeStamps FetchEmployeeTimeStamps(string login) { return Sync(FetchEmployeeTimeStampsAsync(login)); }

		public async Task<EmployeeTimeStamps> SetEmployeeTimeStampsAsync(EmployeeTimeStamps timeStamps) {

			return (await InvokeServiceAsync<EmployeeTimeStamps.RequestFormatted, EmployeeTimeStamps.ResponseFormatted>("PUT", string.Format("employees/{0}", timeStamps.login), timeStamps.format())).parse();
		}

		public EmployeeTimeStamps SetEmployeeTimeStamps(EmployeeTimeStamps timeStamps) { return Sync(SetEmployeeTimeStampsAsync(timeStamps)); }

		private async Task<R> InvokeServiceAsync<Q, R>(string method, string path, Q body) {

			var req = WebRequest.CreateHttp(new UriBuilder("http", host, Port, path).Uri);
			req.Method = method;
			req.ContentType = "application/json";

			using (var stm = new StreamWriter(await req.GetRequestStreamAsync()))
				await stm.WriteAsync(JsonConvert.SerializeObject(body));

			var res = (HttpWebResponse)await req.GetResponseAsync();
			using (var stm = new StreamReader(res.GetResponseStream()))
				return JsonConvert.DeserializeObject<R>(await stm.ReadToEndAsync());
		}

		private async Task<R> RequestServiceAsync<R>(string path) {

			var req = WebRequest.CreateHttp(new UriBuilder("http", host, Port, path).Uri);
			var res = (HttpWebResponse)await req.GetResponseAsync();
			using (var stm = new StreamReader(res.GetResponseStream()))
				return JsonConvert.DeserializeObject<R>(await stm.ReadToEndAsync());
		}

		private T Sync<T>(Task<T> async) {

			async.Wait();
			return async.Result;
		}
	}
}
