using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using c = System.Console;

namespace BFH.NetDS.WebServices.CodingSession.Service {

	public static class Program {

		public static void Main() {

			using (var hst = new ServiceHost(typeof(UserService), new Uri("http://localhost:5555/"))) {
				var mta = hst.Description.Behaviors.Find<ServiceMetadataBehavior>();
				if (mta == null) hst.Description.Behaviors.Add(mta = new ServiceMetadataBehavior());
				mta.HttpGetEnabled = true;

				hst.Open();
				c.ReadLine();
			}
		}
	}
}
