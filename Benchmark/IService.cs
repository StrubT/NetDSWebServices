using System.ServiceModel;
using System.ServiceModel.Web;

namespace BFH.NetDS.WebServices.Benchmark {

	[ServiceContract]
	public interface IService {

		[OperationContract, WebGet(UriTemplate = "HostInformation", ResponseFormat = WebMessageFormat.Json)]
		HostInformation GetHostInformation();
	}
}
