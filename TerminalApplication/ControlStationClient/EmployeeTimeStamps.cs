using System;
using System.Collections.Generic;
using System.Linq;

namespace BFH.NetDS.WebServices.Terminal.ControlStationClient {

	public class EmployeeTimeStamps {

		public string login { get; set; }

		public List<DateTime> timeStamps { get; set; }

		public TimeSpan timeSpan { get; set; }
	}
}
