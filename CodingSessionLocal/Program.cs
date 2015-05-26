using System.Linq;
using c = System.Console;

namespace BFH.NetDS.WebServices.CodingSession.Local {

	public static class Program {

		public static void Main() {

			var usrs = User.fetchUsers();
			foreach (var usr in usrs)
				c.WriteLine("{0,-25} - {1}", usr.accountName, usr.name);

			c.WriteLine(new string('-', 55));

			foreach (var usr in usrs.Select(u => User.fetchUser(u.accountName)))
				c.WriteLine("{0,-25} - {1,-25} - {2:yyyy-MM-dd HH:mm}", usr.accountName, usr.name, usr.lastLogon);
		}
	}
}
