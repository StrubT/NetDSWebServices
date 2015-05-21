using System;
using System.Linq;

namespace BFH.NetDS.WebServices.Benchmark {

	public class Service : IService {

		public HostInformation hostInformation { get; private set; }

		public Service() {

			var envVars = Environment.GetEnvironmentVariables();

			hostInformation = new HostInformation() {
				hostName = Environment.MachineName,
				userName = Environment.UserName,
				operatingSystem = Environment.OSVersion.VersionString,
				processorCount = Environment.ProcessorCount,
				workingSet = Environment.WorkingSet,
				environmentVariables = envVars.Keys.Cast<string>().Select(k => new EnvironmentVariable() { name = k, value = envVars[k].ToString() }).ToList(),
				drives = Environment.GetLogicalDrives().Select(d => d[0]).ToList(),
				specialFolders = Enum.GetValues(typeof(Environment.SpecialFolder)).Cast<Environment.SpecialFolder>().Distinct().Select(f => new SpecialFolder() { type = f, path = Environment.GetFolderPath(f) }).ToList()
			};
		}

		HostInformation IService.GetHostInformation() { return hostInformation; }
	}
}
