using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BFH.NetDS.WebServices.Benchmark.RESTServiceClient {

	internal class ServiceClient {

		public Uri root { get; private set; }

		public ServiceClient(Uri root) {

			this.root = root;
		}

		public HostInformation GetHostInformation() {

			using (var stm = new StreamReader(WebRequest.CreateHttp(new Uri(root, "HostInformation")).GetResponse().GetResponseStream()))
				return JsonConvert.DeserializeObject<HostInformation>(stm.ReadToEnd());
		}

		public async Task<HostInformation> GetHostInformationAsync() {

			using (var stm = new StreamReader((await WebRequest.CreateHttp(new Uri(root, "HostInformation")).GetResponseAsync()).GetResponseStream()))
				return JsonConvert.DeserializeObject<HostInformation>(await stm.ReadToEndAsync());
		}
	}
}
