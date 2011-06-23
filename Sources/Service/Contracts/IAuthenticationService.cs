

namespace Kanlex.Service.Service.Contracts {
	using Kanlex.Service.Service.Models;

	interface IAuthenticationService {
		Session Authenticate(string login, string password);
		void Register(string login, string password);
	}
}
