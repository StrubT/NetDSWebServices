using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BFH.NetDS.WebServices.Terminal {

	public partial class MainForm : Form {

		private ServiceHost serviceHost;
		private TerminalService service;

		public MainForm() {
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e) {

			serviceHost = TerminalService.GetServiceHost();
			service = (TerminalService)serviceHost.SingletonInstance;
		}

		private void MainForm_FormClosed(object sender, FormClosedEventArgs e) {

			if (serviceHost != null)
				serviceHost.Close();
		}
	}
}
