using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace BFH.NetDS.WebServices.Terminal {

[ServiceContract]
public	class TerminalService {

		public static readonly Uri Uri = new Uri("http://localhost:6789/");

		public static ServiceHost GetServiceHost() {

			var host = new ServiceHost(typeof(TerminalService), Uri);
			var meta = new ServiceMetadataBehavior();
			meta.HttpGetEnabled = true;
			host.Description.Behaviors.Add(meta);

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
