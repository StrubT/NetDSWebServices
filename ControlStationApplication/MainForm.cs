using System;
using System.Data;
using System.Linq;
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
		}

		private void MainForm_FormClosed(object sender, FormClosedEventArgs e) {

			if (serviceHost != null)
				serviceHost.Close();
		}

		private async void newsChangeButton_Click(object sender, EventArgs e) {

			var news = newsChangeTextBox.Rtf;

			newsStatusDataTable.Rows.Clear();
			var trms = ControlStationService.terminals.ToDictionary(t => t, t => newsStatusDataTable.Rows.Add(t.HostName, "awaiting..."));

			foreach (var trm in trms)
				using (var clt = new TerminalServiceClient(new BasicHttpBinding(), new EndpointAddress(new UriBuilder("http", trm.Key.AddressList[0].ToString(), 5678).Uri))) {
					await clt.SetNewsAsync(news);
					trm.Value.SetField<string>("status", "done!");
				}
		}
	}
}
