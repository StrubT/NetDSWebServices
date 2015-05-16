using System;
using System.Data;
using System.Linq;
using System.ServiceModel;
using System.Windows.Forms;
using BFH.NetDS.WebServices.Terminal.ControlStationClient;

namespace BFH.NetDS.WebServices.Terminal {

	public partial class MainForm : Form {

		private ServiceHost serviceHost;
		private bool suppressAutoSelection;

		public Statistics statistics { get; private set; }

		public ControlStationServiceClient serviceClient { get; private set; }

		public MainForm() {

			InitializeComponent();

			statistics = new Statistics();
		}

		private void MainForm_Load(object sender, EventArgs e) {

			serviceHost = TerminalService.GetServiceHost(newsTextBox, statistics);
		}

		private void MainForm_FormClosed(object sender, FormClosedEventArgs e) {

			if (serviceHost != null)
				serviceHost.Close();
		}

		private async void connectButton_Click(object sender, EventArgs e) {

			hostTextBox.ReadOnly = true;
			connectButton.Enabled = false;
			serviceClient = new ControlStationServiceClient(hostTextBox.Text);

			suppressAutoSelection = true;

			foreach (var emp in await serviceClient.FetchEmployeesAsync())
				employeeDataTable.Rows.Add(emp.login, emp.name);

			employeeDataGridView.ClearSelection();
			suppressAutoSelection = false;
		}

		private async void addEmployeeButton_Click(object sender, EventArgs e) {

			var form = new EmployeeAddForm();
			if (form.ShowDialog() == DialogResult.Cancel) return;

			if (string.IsNullOrWhiteSpace(form.login) || string.IsNullOrWhiteSpace(form.name)) {
				MessageBox.Show("You have to enter a login and a name.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			await serviceClient.AddEmployeeAsync(new Employee() { login = form.login, name = form.name });

			suppressAutoSelection = true;

			employeeDataTable.Rows.Clear();
			foreach (var emp in await serviceClient.FetchEmployeesAsync())
				employeeDataTable.Rows.Add(emp.login, emp.name);

			employeeDataGridView.ClearSelection();
			suppressAutoSelection = false;
		}

		private void employeeDataGridView_SelectionChanged(object sender, EventArgs e) {
			if (suppressAutoSelection) return;

			var row = employeeDataGridView.SelectedRows.Cast<DataGridViewRow>().SingleOrDefault();
			if (row == null) return;

			employeeDataGridView.ClearSelection();
			new EmployeeDetailsForm(this, ((DataRowView)row.DataBoundItem).Row.Field<string>("login")).ShowDialog();
		}
	}
}
