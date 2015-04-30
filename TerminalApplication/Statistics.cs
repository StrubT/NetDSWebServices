using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BFH.NetDS.WebServices.Terminal {
	
	[DataContract]
	public class Statistics {

		[DataMember]
		public int numberOfUniqueUsers { get; private set; }

		[DataMember]
		public int numberOfTimeStamps { get; private set; }

		public Statistics(int numberOfUniqueUsers, int numberOfTimeStamps) {
			this.numberOfUniqueUsers = numberOfUniqueUsers;
			this.numberOfTimeStamps = numberOfTimeStamps;
		}

	}
}
