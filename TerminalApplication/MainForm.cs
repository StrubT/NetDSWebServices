using System;
using System.ServiceModel;
using System.Windows.Forms;
using BFH.NetDS.WebServices.Terminal.ControlStationClient;

namespace BFH.NetDS.WebServices.Terminal {

	public partial class MainForm : Form {

		private Statistics statistics = new Statistics();
		private ServiceHost serviceHost;
		private ControlStationServiceClient serviceClient;

		public MainForm() {

			InitializeComponent();
		}

		private async void MainForm_Load(object sender, EventArgs e) {

			serviceHost = TerminalService.GetServiceHost(newsTextBox, statistics);
			serviceClient = new ControlStationServiceClient("localhost");

			foreach (var emp in await serviceClient.FetchEmployeesAsync())
				employeeDataTable.Rows.Add(emp.login, emp.name);
		}

		private void MainForm_FormClosed(object sender, FormClosedEventArgs e) {

			if (serviceHost != null)
				serviceHost.Close();
		}
	}
}
