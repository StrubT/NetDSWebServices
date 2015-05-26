using System.Linq;
using c = System.Console;

namespace BFH.NetDS.WebServices.CodingSession.Local {

	public static class Program {

		public static void Main() {

			foreach (var usr in User.fetchUsers())
				c.WriteLine("{0,-25} - {1}", usr.login, usr.name);

			c.WriteLine(new string('-', 55));

			foreach (var usr in new[] { User.fetchUser("ThS"), User.fetchUser("AdmThS") })
				c.WriteLine("{0,-25} - {1,-25} - {2:yyyy-MM-dd HH:mm}", usr.login, usr.name, usr.lastLogon);
		}
	}
}
