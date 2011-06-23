
namespace Kanlex.Service.Service.Services {
	using Kanlex.Service.Service.Contracts;
	using Kanlex.Service.Service.Models;
	using Kanlex.Service.Service.Repositories;

	class AuthenticationService : IAuthenticationService {
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

		public void Register(string login, string password) {
			bool userRegistered = pUserRepository.Contains(login);
			
			if (userRegistered)
				return;

			pUserRepository.Insert(new User(login, password));
		}

		private UserRepository pUserRepository = UserRepository.Instance;
		private SessionRepository pSessionRepository = SessionRepository.Instance;
	}
}
