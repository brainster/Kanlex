
namespace Kanlex.Service.Service.Repositories {
	using System.Linq;
	using System.Collections.Generic;
	using Kanlex.Service.Service.Models;

	class UserRepository {
		public User Get(string login) {
			return pRepository[login];
		}

		public void Insert(User user) {
			pRepository.Add(user.Login, user);
		}

		public bool Contains(string login) {
			return pRepository.ContainsKey(login);
		}

		private Dictionary<string, User> pRepository = new Dictionary<string, User>();

		private static UserRepository pInstance = new UserRepository();
		public static UserRepository Instance { get { return pInstance; } }
	}
}
