using System;
using System.ServiceModel;

namespace BFH.NetDS.WebServices.Terminal {

	[ServiceContract]
	public class TerminalService {

		public static readonly Uri Uri = new Uri("http://localhost:5678/");

		public static ServiceHost GetServiceHost() {

			var host = new ServiceHost(typeof(TerminalService), Uri);
			host.Open();

			return host;
		}

		[OperationContract]
		public void SetNews(string news) {

		}

		[OperationContract]
		public Statistics GetStatistics() {

			return new Statistics(1, 2);
		}
	}
}
