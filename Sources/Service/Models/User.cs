
namespace Kanlex.Service.Models {
	using System;
	using System.Runtime.Serialization;

	[DataContract]
	class User : IEquatable<User> {
		public User(string login, string password) {
			Login = login;
			Password = password;
		}

		public bool Equals(User other) {
			return Login.Equals(other.Login);
		}

		/// <summary>Gets login.</summary>
		[DataMember]
		public string Login { get; private set; }

		/// <summary>Gets or sets password.</summary>
		[DataMember]
		public string Password { get; set; }
	}
}
