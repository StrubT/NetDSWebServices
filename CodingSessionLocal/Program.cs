using System.Linq;
using c = System.Console;

namespace BFH.NetDS.WebServices.CodingSession.Local {

	public static class Program {

		public static void Main() {

			var usrs = User.fetchUsers();
			foreach (var usr in usrs)
				c.WriteLine("{0,-25} - {1}", usr.accountName, usr.name);

			c.WriteLine(new string('-', 55));

			c.Write("Please enter an account name: ");
			var use = User.fetchUser(c.ReadLine());
			c.WriteLine("{0,-25} - {1,-25} - {2:yyyy-MM-dd HH:mm}", use.accountName, use.name, use.lastLogon);
		}
	}
}
