using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;

namespace BFH.NetDS.WebServices.ControlStation {

	[DataContract]
	public class EmployeeTimeStamps {

		[DataMember]
		public string login { get; private set; }

		public List<DateTime> timeStamps { get; private set; }

		[DataMember(Name = "timeStamps")]
		public List<string> timeStampsFormatted {
			get {
				return (timeStamps != null ? timeStamps.Select(t => t.ToString("o")) : new string[] { }).ToList();
			}
			set {
				if (timeStamps == null) timeStamps = new List<DateTime>();
				timeStamps.AddRange(value.Select(t => DateTime.ParseExact(t, "o", CultureInfo.InvariantCulture)));
			}
		}

		public TimeSpan timeSpan {
			get {
				var dts = timeStamps.OrderBy(d => d).ToList();
				var ts = new TimeSpan();
				for (var i = 0; i < dts.Count - 1; )
					if (dts[i].Date == dts[i + 1].Date) {
						ts += dts[i + 1] - dts[i];
						i += 2;
					} else
						i++;

				return ts;
			}
		}

		[DataMember(Name = "timeSpan")]
		public string timeSpanFormatted {
			get { return timeSpan.ToString("c"); }
			set { throw new InvalidOperationException("Cannot change the timespan directly."); }
		}

		public EmployeeTimeStamps(string login, IEnumerable<DateTime> dateTimes) {

			this.login = login;
			this.timeStamps = dateTimes.ToList();
		}

		public EmployeeTimeStamps(string login, params DateTime[] dateTimes)
			: this(login, (IEnumerable<DateTime>)dateTimes) { }

		public EmployeeTimeStamps(string login, IEnumerable<string> timeStamps) {

			this.login = login;
			this.timeStampsFormatted = timeStamps.ToList();
		}

		public EmployeeTimeStamps(string login, params string[] timeStamps)
			: this(login, (IEnumerable<string>)timeStamps) { }
	}
}
