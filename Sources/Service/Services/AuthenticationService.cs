
namespace Kanlex.Service.Services {
	using System.ServiceModel;
	using Kanlex.Service.Contracts;
	using Kanlex.Service.Managers;
	using Kanlex.Service.Models;

	[ServiceBehavior(InstanceContextMode=InstanceContextMode.PerSession)]
	class AuthenticationService : IAuthenticationService {
		public Session Authenticate(string login, string password) {
			return pManager.Authenticate(login, password);
		}

		public void Register(string login, string password) {
			pManager.Register(login, password);
		}

		private AuthenticationManager pManager = AuthenticationManager.Instance;
	}
}
