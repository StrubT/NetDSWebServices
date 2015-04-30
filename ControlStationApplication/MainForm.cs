using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BFH.NetDS.WebServices.ControlStation {

	public partial class MainForm : Form {

		private WebServiceHost serviceHost;
		private ControlStationService service;

		public MainForm() {

			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e) {

			serviceHost = ControlStationService.GetServiceHost();
			service = (ControlStationService)serviceHost.SingletonInstance;
		}

		private void MainForm_FormClosed(object sender, FormClosedEventArgs e) {

			if (serviceHost != null)
				serviceHost.Close();
		}

		private void newsChangeButton_Click(object sender, EventArgs e) {

		}
	}
}
