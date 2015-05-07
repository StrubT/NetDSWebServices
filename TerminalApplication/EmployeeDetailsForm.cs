using System;
using System.Windows.Forms;

namespace BFH.NetDS.WebServices.Terminal {

	public partial class EmployeeDetailsForm : Form {

		private MainForm mainForm;
		private string employeeLogin;

		public EmployeeDetailsForm(MainForm mainForm, string employeeLogin) {

			InitializeComponent();

			this.mainForm = mainForm;
			this.employeeLogin = employeeLogin;
		}

		private void EmployeeDetailsForm_Load(object sender, EventArgs e) {

		}

		private void timeStampButton_Click(object sender, EventArgs e) {

			mainForm.statistics.uniqueUsers.Add(employeeLogin);
			mainForm.statistics.numberOfTimeStamps++;
		}

		private void closeButton_Click(object sender, EventArgs e) {

		}
	}
}
