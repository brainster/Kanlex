
namespace Kanlex.Service.Contracts {
	using System.ServiceModel;
	using Kanlex.Service.Models;

	[ServiceContract(
		Name = "Communication",
		Namespace = "brainster.org",
		SessionMode = SessionMode.Required)]
	interface ICommunicationService {
		[OperationContract(Name = "Authenticate")]
		void Authenticate(Session session);

		[OperationContract(
			Name = "Say",
			IsInitiating = false)]
		void Say(string message);
	}
}
