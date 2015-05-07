using System;
using System.Data;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Windows.Forms;
using BFH.NetDS.WebServices.ControlStation.TerminalClient;

namespace BFH.NetDS.WebServices.ControlStation {

	public partial class MainForm : Form {

		private WebServiceHost serviceHost;

		public MainForm() {

			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e) {

			serviceHost = ControlStationService.GetServiceHost();
			ControlStationService.terminalConnected += ControlStationService_terminalConnected;
		}

		private void MainForm_FormClosed(object sender, FormClosedEventArgs e) {

			if (serviceHost != null)
				serviceHost.Close();
		}

		private async void ControlStationService_terminalConnected(IPHostEntry terminal) {

			newsStatusDataTable.Rows.Add(terminal.HostName, "connected...");

			using (var clt = new TerminalServiceClient(new BasicHttpBinding(), new EndpointAddress(new UriBuilder("http", terminal.AddressList[0].ToString(), 5678).Uri))) {
				await clt.SetNewsAsync(newsChangeTextBox.Rtf);
				newsStatusDataTable.Rows.Find(terminal.HostName).SetField<string>("status", "done!");
			}
		}

		private async void newsChangeButton_Click(object sender, EventArgs e) {

			var news = newsChangeTextBox.Rtf;

			foreach (var row in newsStatusDataTable.Rows.Cast<DataRow>())
				row.SetField("status", "awaiting...");

			foreach (var trm in ControlStationService.terminals)
				using (var clt = new TerminalServiceClient(new BasicHttpBinding(), new EndpointAddress(new UriBuilder("http", trm.AddressList[0].ToString(), 5678).Uri))) {
					await clt.SetNewsAsync(news);
					newsStatusDataTable.Rows.Find(trm.HostName).SetField<string>("status", "done!");
				}
		}

		private async void tabControl_Selected(object sender, TabControlEventArgs e) {

			if (e.TabPage == statisticsTab) {
				statisticsDataTable.Rows.Clear();
				var trms = ControlStationService.terminals.ToDictionary(t => t, t => statisticsDataTable.Rows.Add(t.HostName, 0, 0));

				foreach (var trm in trms)
					using (var clt = new TerminalServiceClient(new BasicHttpBinding(), new EndpointAddress(new UriBuilder("http", trm.Key.AddressList[0].ToString(), 5678).Uri))) {
						var stt = await clt.GetStatisticsAsync();
						trm.Value.SetField<int>("uniqueUsers", stt.numberOfUniqueUsers);
						trm.Value.SetField<int>("timeStamps", stt.numberOfTimeStamps);
					}
			}
		}
	}
}
