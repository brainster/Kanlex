
namespace Kanlex.Service.Contracts {
	using System.ServiceModel;
	using Kanlex.Service.Models;

	[ServiceContract(
		Name = "Authentication",
		Namespace = "brainster.org",
		SessionMode = SessionMode.Allowed)]
	interface IAuthenticationService {
		[OperationContract(Name = "Authenticate")]
		Session Authenticate(string login, string password);

		[OperationContract(Name = "Register", IsOneWay = true)]
		void Register(string login, string password);
	}
}
