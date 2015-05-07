using System;
using System.Data;
using System.Linq;
using System.ServiceModel;
using System.Windows.Forms;
using BFH.NetDS.WebServices.Terminal.ControlStationClient;

namespace BFH.NetDS.WebServices.Terminal {

	public partial class MainForm : Form {

		private ServiceHost serviceHost;

		public Statistics statistics { get; private set; }

		public ControlStationServiceClient serviceClient { get; private set; }

		public MainForm() {

			InitializeComponent();

			statistics = new Statistics();
		}

		private void MainForm_Load(object sender, EventArgs e) {

			serviceHost = TerminalService.GetServiceHost(newsTextBox, statistics);
		}

		private async void connectButton_Click(object sender, EventArgs e) {

			hostTextBox.ReadOnly = true;
			portTextBox.ReadOnly = true;
			connectButton.Enabled = false;

			serviceClient = new ControlStationServiceClient(hostTextBox.Text, int.Parse(portTextBox.Text));

			foreach (var emp in await serviceClient.FetchEmployeesAsync())
				employeeDataTable.Rows.Add(emp.login, emp.name);

			employeeDataGridView.ClearSelection();
		}

		private void employeeDataGridView_SelectionChanged(object sender, EventArgs e) {

			foreach (var row in employeeDataGridView.SelectedRows.Cast<DataGridViewRow>())
				new EmployeeDetailsForm(this, ((DataRowView)row.DataBoundItem).Row.Field<string>("login")).ShowDialog();

			employeeDataGridView.ClearSelection();
		}

		private void MainForm_FormClosed(object sender, FormClosedEventArgs e) {

			if (serviceHost != null)
				serviceHost.Close();
		}
	}
}
