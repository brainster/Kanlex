
namespace Kanlex.Service.Repositories {
	using System.Collections.Generic;
	using Kanlex.Service.Models;

	class SessionRepository {
		public void Insert(Session session) {
			pRepository.Add(session.Id, session);
		}

		private Dictionary<string, Session> pRepository = new Dictionary<string, Session>();

	}
}
