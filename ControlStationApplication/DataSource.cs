using System;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Xml.Linq;

namespace BFH.NetDS.WebServices.ControlStation {

	internal class DataSource : IDisposable {

#if DEBUG
		public static readonly FileInfo File = new FileInfo(Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "data.xml"));
#else
		public static readonly FileInfo File = new FileInfo("data.xml");
#endif

		private static readonly Semaphore WritableSemaphore = new Semaphore(1, 1);

		public bool readOnly { get; private set; }

		public XDocument document { get; private set; }

		public DataSource() : this(false) { }

		public DataSource(bool readOnly) {

			this.readOnly = readOnly;

			if (!readOnly)
				WritableSemaphore.WaitOne();
			document = XDocument.Load(File.FullName);
		}

		public void Dispose() {

			if (!readOnly) {
				document.Save(File.FullName);
				WritableSemaphore.Release();
			}
		}
	}
}
