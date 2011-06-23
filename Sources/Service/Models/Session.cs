
namespace Kanlex.Service.Service.Models {
	using System;

	/// <summary>Session</summary>
	class Session : IEquatable<Session> {
		public Session(User user) {
			User = user;
			Id = Guid.NewGuid().ToString();
		}

		public bool Equals(Session other) {
			return Id.Equals(other.Id);
		}

		/// <summary>Gets session Id.</summary>
		public string Id { get; private set; }

		/// <summary>Gets user session created for.</summary>
		public User User { get; private set; }
	}
}
