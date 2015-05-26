using System;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Web;
using c = System.Console;

namespace BFH.NetDS.WebServices.Benchmark {

	public static class Program {

		const int BenchmarkIterations = 10000;

		public static void Main(string[] args) {

			var uriSOAP = new Uri("http://localhost:3456/");
			var uriREST = new Uri("http://localhost:4567/");

			var srv = new Service();
			TimeSpan timSOAP, timREST;

			using (var hstSOAP = new ServiceHost(srv, uriSOAP))
			using (var hstREST = new WebServiceHost(srv, uriREST)) {

				foreach (var hst in new[] { hstSOAP, hstREST }) {
					var bhv = hst.Description.Behaviors.Find<ServiceBehaviorAttribute>();
					if (bhv == null) hst.Description.Behaviors.Add(bhv = new ServiceBehaviorAttribute());
					bhv.InstanceContextMode = InstanceContextMode.Single;

#if DEBUG
					bhv.IncludeExceptionDetailInFaults = true;

					var mta = hst.Description.Behaviors.Find<ServiceMetadataBehavior>();
					if (mta == null) hst.Description.Behaviors.Add(mta = new ServiceMetadataBehavior());
					mta.HttpGetEnabled = true;
#endif

					hst.Open();
				}

#if DEBUG
				c.ReadLine();
#endif

				var cltSOAP = new SOAPServiceClient.ServiceClient(new BasicHttpBinding(), new EndpointAddress(uriSOAP));
				timSOAP = Profile(BenchmarkIterations, () => cltSOAP.GetHostInformation());
				c.WriteLine("SOAP: {0:#,##0} requests in {1}ms", BenchmarkIterations, timSOAP.TotalMilliseconds);

				var cltREST = new RESTServiceClient.ServiceClient(uriREST);
				timREST = Profile(BenchmarkIterations, () => cltREST.GetHostInformation());
				c.WriteLine("REST: {0:#,##0} requests in {1}ms", BenchmarkIterations, timREST.TotalMilliseconds);
			}
		}

		static TimeSpan Profile(int iterations, Action action) { //source: http://stackoverflow.com/a/1048708/1325979

			// warm up 
			action();

			var watch = new Stopwatch();

			// clean up
			GC.Collect();
			GC.WaitForPendingFinalizers();
			GC.Collect();

			watch.Start();
			for (int i = 0; i < iterations; i++)
				action();

			watch.Stop();
			return watch.Elapsed;
		}
	}
}
