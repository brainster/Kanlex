
namespace Kanlex.Service.Service {
	using System;
	using System.ServiceModel;

	class Application {
		public static void Main() {
			// netsh http add urlacl url=http://+:8000/ user=DOMAIN\UserName"
				using (ServiceHost host = new ServiceHost(
				typeof(Kanlex.Service.Services.AuthenticationService))) {
				host.Open();
				// other code
			}

			Console.WriteLine("Started.");
			Console.ReadLine();
		}
	}
}
