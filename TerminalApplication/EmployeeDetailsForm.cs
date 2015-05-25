using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BFH.NetDS.WebServices.Terminal.ControlStationClient;

namespace BFH.NetDS.WebServices.Terminal {

	public partial class EmployeeDetailsForm : Form {

		private MainForm mainForm;
		private string employeeLogin;

		public EmployeeDetailsForm(MainForm mainForm, string employeeLogin) {

			InitializeComponent();

			this.mainForm = mainForm;
			this.employeeLogin = employeeLogin;

			this.Text = string.Format("NetDS - Web Services - {0} Details", employeeLogin);
		}

		private async void EmployeeDetailsForm_Load(object sender, EventArgs e) {

			showTimeStamps(await mainForm.serviceClient.FetchEmployeeTimeStampsAsync(employeeLogin));
		}

		private async void timeStampButton_Click(object sender, EventArgs e) {

			var timeStamp = DateTime.Now;

			mainForm.statistics.uniqueUsers.Add(employeeLogin);
			mainForm.statistics.numberOfTimeStamps++;

			showTimeStamps(await mainForm.serviceClient.SetEmployeeTimeStampsAsync(new EmployeeTimeStamps() { login = employeeLogin, timeStamps = new List<DateTime> { timeStamp } }));
		}

		private void showTimeStamps(EmployeeTimeStamps timeStamps) {

			timeStampsDataTable.Rows.Clear();

			var ts = new TimeSpan();
			for (var i = 0; i < timeStamps.timeStamps.Count; ) {
				timeStampsDataTable.Rows.Add(timeStamps.timeStamps[i], ts);

				if (i + 1 < timeStamps.timeStamps.Count && timeStamps.timeStamps[i].Date == timeStamps.timeStamps[i + 1].Date) {
					ts += timeStamps.timeStamps[i + 1] - timeStamps.timeStamps[i];
					timeStampsDataTable.Rows.Add(timeStamps.timeStamps[i + 1], ts);
					i += 2;
				} else
					i++;
			}
		}

		private void closeButton_Click(object sender, EventArgs e) {

			Close();
		}
	}
}
