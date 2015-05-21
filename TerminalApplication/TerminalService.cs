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
			var bhv = host.Description.Behaviors.Find<ServiceBehaviorAttribute>();
			if (bhv == null) host.Description.Behaviors.Add(bhv = new ServiceBehaviorAttribute());
			bhv.IncludeExceptionDetailInFaults = true;

			var mta = host.Description.Behaviors.Find<ServiceMetadataBehavior>();
			if (mta == null) host.Description.Behaviors.Add(mta = new ServiceMetadataBehavior());
			mta.HttpGetEnabled = true;
#endif

			host.Open();
			return host;
		}
	}
}
