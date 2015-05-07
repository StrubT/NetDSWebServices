using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace BFH.NetDS.WebServices.Terminal {

	[DataContract]
	public class Statistics {

		public HashSet<string> uniqueUsers { get; private set; }

		[DataMember]
		public int numberOfUniqueUsers {
			get { return uniqueUsers.Count; }
			private set { throw new InvalidOperationException("Cannot change the numberOfUniqueUsers directly."); }
		}

		[DataMember]
		public int numberOfTimeStamps { get; set; }

		public Statistics() : this(new HashSet<string>(), 0) { }

		public Statistics(HashSet<string> uniqueUsers, int numberOfTimeStamps) {

			this.uniqueUsers = uniqueUsers;
			this.numberOfTimeStamps = numberOfTimeStamps;
		}
	}
}
