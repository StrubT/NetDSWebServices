using System;
using System.IO;
using System.Threading;
using System.Xml.Linq;

namespace BFH.NetDS.WebServices.ControlStation {

	internal class DataSource : IDisposable {

		public static readonly FileInfo File = new FileInfo("./data.xml");
		private static readonly Semaphore semaphore = new Semaphore(1, 1);

		public XDocument document { get; private set; }

		public DataSource() {

			semaphore.WaitOne();
			document = XDocument.Load(File.FullName);
		}

		public void Dispose() {

			document.Save(File.FullName);
			semaphore.Release();
		}
	}
}
