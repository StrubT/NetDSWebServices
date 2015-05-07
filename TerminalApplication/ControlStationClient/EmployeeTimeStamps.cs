using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace BFH.NetDS.WebServices.Terminal.ControlStationClient {

	public class EmployeeTimeStamps {

		public string login { get; set; }

		public List<DateTime> timeStamps { get; set; }

		public TimeSpan timeSpan { get; set; }

		public RequestFormatted format() {

			return new RequestFormatted() {
				timeStamps = timeStamps.Select(s => s.ToString("o")).ToList(),
			};
		}

		public class RequestFormatted {

			public List<string> timeStamps { get; set; }
		}

		public class ResponseFormatted {

			public string login { get; set; }

			public List<string> timeStamps { get; set; }

			public string timeSpan { get; set; }

			public EmployeeTimeStamps parse() {

				return new EmployeeTimeStamps() {
					login = login,
					timeStamps = timeStamps.Select(s => DateTime.ParseExact(s, "o", CultureInfo.InvariantCulture)).ToList(),
					timeSpan = TimeSpan.ParseExact(timeSpan, "c", CultureInfo.InvariantCulture)
				};
			}
		}
	}
}
