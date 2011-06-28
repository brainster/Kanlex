
namespace Kanlex.Service.Repositories {
	using System.Linq;
	using System.Collections.Generic;
	using Kanlex.Service.Models;

	class UserRepository {
		public User Get(string login) {
			return pDatabase.Users.Single(x => x.Login == login);
		}

		public void Insert(User user) {
			pDatabase.Users.Add(user);
		}

		public bool Contains(string login) {
			return pDatabase.Users.Any(x => x.Login == login);
		}

		private DatabaseContext pDatabase = new DatabaseContext();
	}
}
