using System;
using System.IO;
using System.Threading;
using System.Xml.Linq;

namespace BFH.NetDS.WebServices.ControlStation {

	internal class DataSource : IDisposable {

		public static readonly FileInfo File = new FileInfo("./data.xml");
		private static readonly Semaphore Semaphore = new Semaphore(1, 1);

		public bool readOnly { get; private set; }

		public XDocument document { get; private set; }

		public DataSource() : this(false) { }

		public DataSource(bool readOnly) {

			this.readOnly = readOnly;

			if (!readOnly)
				Semaphore.WaitOne();
			document = XDocument.Load(File.FullName);
		}

		public void Dispose() {

			if (!readOnly) {
				document.Save(File.FullName);
				Semaphore.Release();
			}
		}
	}
}
