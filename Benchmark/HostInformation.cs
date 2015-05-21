using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace BFH.NetDS.WebServices.Benchmark {

	[DataContract]
	public class HostInformation {

		[DataMember]
		public string hostName { get; set; }

		[DataMember]
		public string userName { get; set; }

		[DataMember]
		public string operatingSystem { get; set; }

		[DataMember]
		public int processorCount { get; set; }

		[DataMember]
		public long workingSet { get; set; }

		[DataMember]
		public List<EnvironmentVariable> environmentVariables { get; set; }

		[DataMember]
		public List<char> drives { get; set; }

		[DataMember]
		public List<SpecialFolder> specialFolders { get; set; }
	}

	[DataContract]
	public class EnvironmentVariable {

		[DataMember]
		public string name { get; set; }

		[DataMember]
		public string value { get; set; }
	}

	[DataContract]
	public class SpecialFolder {

		public Environment.SpecialFolder type { get; set; }

		public string path { get; set; }
	}
}
