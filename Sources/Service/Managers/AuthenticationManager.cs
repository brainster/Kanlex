
namespace Kanlex.Service.Managers {
	using Kanlex.Service.Models;
	using Kanlex.Service.Repositories;

	class AuthenticationManager {
		/// <summary>Authenticates user by login/password pair.</summary>
		/// <param name="login">Login.</param>
		/// <param name="password">Password.</param>
		/// <returns>Session.</returns>
		public Session Authenticate(string login, string password) {
			bool userRegistered = pUserRepository.Contains(login);

			if (!userRegistered) // No user registered
				return null;

			// User registered
			User user = pUserRepository.Get(login);
			Session session = new Session(user);
			pSessionRepository.Insert(session);
			return session;
		}

		/// <summary>Registers new user.</summary>
		/// <param name="login">Login of new user.</param>
		/// <param name="password">Password.</param>
		public void Register(string login, string password) {
			bool userRegistered = pUserRepository.Contains(login);

			if (userRegistered)
				return;

			pUserRepository.Insert(new User(login, password));
		}
		
		public static AuthenticationManager Instance { get; set; }
		private UserRepository pUserRepository = new UserRepository();
		private SessionRepository pSessionRepository = new SessionRepository();
	}
}
