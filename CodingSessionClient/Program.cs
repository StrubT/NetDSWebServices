using c = System.Console;

namespace BFH.NetDS.WebServices.CodingSession.Client {

	public static class Program {

		public static void Main() {

			using (var clt = new UserClient.UserServiceClient()) {

				var usrs = clt.fetchUsers();
				foreach (var usr in usrs)
					c.WriteLine("{0,-25} - {1}", usr.accountName, usr.name);

				c.WriteLine(new string('-', 55));

				c.Write("Please enter an account name: ");
				var use = clt.fetchUser(c.ReadLine());
				c.WriteLine("{0,-25} - {1,-25} - {2:yyyy-MM-dd HH:mm}", use.accountName, use.name, use.lastLogon);
			}
		}
	}
}
