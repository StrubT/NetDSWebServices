using System;
using System.Windows.Forms;

namespace BFH.NetDS.WebServices.Terminal {

	public partial class EmployeeAddForm : Form {

		public string login { get { return loginTextBox.Text; } }

		public string name { get { return nameTextBox.Text; } }

		public EmployeeAddForm() {

			InitializeComponent();

			var cancelButton = new Button();
			cancelButton.Click += (s, e) => Close();
			CancelButton = cancelButton;
		}

		private void addButton_Click(object sender, EventArgs e) {

			DialogResult = DialogResult.OK;
			Close();
		}
	}
}
