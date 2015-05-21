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

		public async Task<List<Employee>> FetchEmployeesAsync() { return await ServiceGetAsync<List<Employee>>("employee"); }

		public List<Employee> FetchEmployees() { return Sync(FetchEmployeesAsync()); }

		public async Task<Employee> AddEmployeeAsync(Employee employee) { return await ServicePostAsync<Employee, Employee>("employee", employee); }

		public Employee AddEmployee(Employee employee) { return Sync(AddEmployeeAsync(employee)); }

		public async Task<EmployeeTimeStamps> FetchEmployeeTimeStampsAsync(String login) { return await ServiceGetAsync<EmployeeTimeStamps>(string.Format("employee/{0}", login)); }

		public EmployeeTimeStamps FetchEmployeeTimeStamps(String login) { return Sync(FetchEmployeeTimeStampsAsync(login)); }

		public async Task<EmployeeTimeStamps> AddEmployeeTimeStampsAsync(EmployeeTimeStamps timeStamps) {

			return (await ServicePostAsync<EmployeeTimeStamps.RequestFormatted, EmployeeTimeStamps.ResponseFormatted>(string.Format("employee/{0}", timeStamps.login), timeStamps.format())).parse();
		}

		public EmployeeTimeStamps AddEmployeeTimeStamps(EmployeeTimeStamps timeStamps) { return Sync(AddEmployeeTimeStampsAsync(timeStamps)); }

		private async Task<R> ServicePostAsync<Q, R>(string path, Q body) {

			var req = WebRequest.CreateHttp(new UriBuilder("http", host, Port, path).Uri);
			req.Method = "POST";
			req.ContentType = "application/json";

			using (var stm = new StreamWriter(await req.GetRequestStreamAsync()))
				await stm.WriteAsync(JsonConvert.SerializeObject(body));

			var res = (HttpWebResponse)await req.GetResponseAsync();
			using (var stm = new StreamReader(res.GetResponseStream()))
				return JsonConvert.DeserializeObject<R>(await stm.ReadToEndAsync());
		}

		private async Task<R> ServiceGetAsync<R>(string path) {

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
