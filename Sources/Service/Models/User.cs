
namespace Kanlex.Service.Service.Models {
	using System;

	class User : IEquatable<User> {
		public User(string login, string password) {
			Login = login;
			Password = password;
		}

		public bool Equals(User other) {
			return Login.Equals(other.Login);
		}

		/// <summary>Gets login.</summary>
		public string Login { get; private set; }

		/// <summary>Gets or sets password.</summary>
		public string Password { get; set; }
	}
}
