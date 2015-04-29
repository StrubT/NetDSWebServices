using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BFH.NetDS.WebServices.ControlStation {

	public partial class MainForm : Form {

		public MainForm() {

			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e) {

			ControlStationService.GetServiceHost();
		}

		private void newsChangeButton_Click(object sender, EventArgs e) {
			
		}
	}
}
