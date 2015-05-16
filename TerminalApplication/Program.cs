using System;
using System.Threading;
using System.Windows.Forms;

namespace BFH.NetDS.WebServices.Terminal {

public	static class Program {

		[STAThread]
	public static void Main() {

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.ThreadException += Application_ThreadException;
			
			Application.Run(new MainForm());
		}

		private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e) {

			MessageBox.Show(string.Format("[{0}] {1}", e.Exception.GetType().Name, e.Exception.Message), "An error occurred!", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}
}
