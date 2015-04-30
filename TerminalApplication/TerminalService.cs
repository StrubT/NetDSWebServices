using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Windows.Forms;

namespace BFH.NetDS.WebServices.Terminal {

	[ServiceContract]
	public class TerminalService {

		public static readonly Uri Uri = new Uri("http://localhost:5678/");

		private static RichTextBox newsTextBox;
		private static Statistics statistics;

		[OperationContract]
		public void SetNews(string news) {

			newsTextBox.Rtf = news;
		}

		[OperationContract]
		public Statistics GetStatistics() {

			return statistics;
		}

		public static ServiceHost GetServiceHost(RichTextBox newsTextBox, Statistics statistics) {

			if (TerminalService.newsTextBox != null)
				throw new InvalidOperationException("Cannot create multiple TerminalService hosts.");

			TerminalService.newsTextBox = newsTextBox;
			TerminalService.statistics = statistics;

			var host = new ServiceHost(typeof(TerminalService), Uri);

#if DEBUG
			var meta = host.Description.Behaviors.Find<ServiceMetadataBehavior>();
			if (meta == null) host.Description.Behaviors.Add(meta = new ServiceMetadataBehavior());
			meta.HttpGetEnabled = true;

			var debug = host.Description.Behaviors.Find<ServiceDebugBehavior>();
			if (debug == null) host.Description.Behaviors.Add(debug = new ServiceDebugBehavior());
			debug.IncludeExceptionDetailInFaults = true;
#endif

			host.Open();
			return host;
		}
	}
}
