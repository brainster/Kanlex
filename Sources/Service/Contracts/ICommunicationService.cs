
namespace Kanlex.Service.Service.Contracts {
	using Kanlex.Service.Service.Models;

	interface ICommunicationService {
		void Authenticate(Session session);
		void Say(string message);
	}
}
