using System.Runtime.Serialization;

namespace BFH.NetDS.WebServices.ControlStation {
	
	[DataContract]
	public class Employee {

		[DataMember]
		public string login { get; private set; }

		[DataMember]
		public string name { get; private set; }

		public Employee(string login, string name) {

			this.login = login;
			this.name = name;
		}
	}
}
