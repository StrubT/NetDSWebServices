using System;
using System.Collections.Generic;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Security.Principal;

namespace BFH.NetDS.WebServices.CodingSession.Local {

	public class UserInfo {

		public string accountName { get; private set; }

		public string name { get; private set; }

		public string description { get; private set; }

		public UserInfo(string accountName, string name, string description) {

			this.accountName = accountName;
			this.name = name;
			this.description = description;
		}
	}

	public class User : UserInfo {

		public DateTime? lastLogon { get; private set; }

		public User(string accountName, string name, string description, DateTime? lastLogon)
			: base(accountName, name, description) {

			this.lastLogon = lastLogon;
		}

		public static List<UserInfo> fetchUsers() {

			using (var ctx = new PrincipalContext(ContextType.Machine))
			using (var src = new PrincipalSearcher(new UserPrincipal(ctx)))
				return (from res in src.FindAll()
								where !Enum.GetValues(typeof(WellKnownSidType)).Cast<WellKnownSidType>().Any(t => res.Sid.IsWellKnown(t))
								select new UserInfo(res.SamAccountName, res.DisplayName, res.Description)).ToList();
		}

		public static User fetchUser(string accountName) {

			using (var ctx = new PrincipalContext(ContextType.Machine)) {
				var usr = UserPrincipal.FindByIdentity(ctx, IdentityType.SamAccountName, accountName);
				return usr != null ? new User(usr.SamAccountName, usr.DisplayName, usr.Description, usr.LastLogon) : null;
			}
		}
	}
}
