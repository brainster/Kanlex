
namespace Kanlex.Service.Models {
	using System;
	using System.Runtime.Serialization;

	/// <summary>Session</summary>
	[DataContract]
	class Session : IEquatable<Session> {
		public Session(User user) {
			User = user;
			Id = Guid.NewGuid().ToString();
		}

		public bool Equals(Session other) {
			return Id.Equals(other.Id);
		}

		/// <summary>Gets session Id.</summary>
		[DataMember]
		public string Id { get; private set; }

		/// <summary>Gets user session created for.</summary>
		[DataMember]
		public User User { get; private set; }
	}
}
