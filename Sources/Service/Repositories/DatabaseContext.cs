
namespace Kanlex.Service.Repositories {
	using System.Collections.Generic;
	using Kanlex.Service.Models;

	class DatabaseContext {
		public List<User> Users = new List<User>();
		public List<Session> Sessions = new List<Session>();
	}
}
