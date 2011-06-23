
namespace Kanlex.Service.Service.Repositories {
	using System.Collections.Generic;
	using Kanlex.Service.Service.Models;

	class SessionRepository {
		public void Insert(Session session) {
			pRepository.Add(session.Id, session);
		}

		private Dictionary<string, Session> pRepository = new Dictionary<string, Session>();
		private static SessionRepository pInstance = new SessionRepository();
		public static SessionRepository Instance { get { return pInstance; } }
	}
}
