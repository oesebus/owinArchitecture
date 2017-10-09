using System;
using System.Threading.Tasks;
using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace Kenzardi.Firebase.ConsoleListener
{
	class MainClass
	{

		protected const string BasePath = "https://firesharp.firebaseio.com/";
		protected const string FirebaseSecret = "fubr9j2Kany9KU3SHCIHBLm142anWCzvlBs1D977";
		private static FirebaseClient _client;

		public static void Main(string[] args)
		{
			Console.WriteLine("Firebase Event listener!");

			IFirebaseConfig config = new FirebaseConfig
			{
				AuthSecret = FirebaseSecret,
				BasePath = "https://kenzardi-121f4.firebaseio.com"
			};

			_client = new FirebaseClient(config);

			EventStreaming();

			Console.Read();

		}

		private static async void EventStreaming()
		{
			await _client.DeleteAsync("chat");

			await _client.OnAsync("chat",
				async (sender, args, context) =>
				{
					System.Console.WriteLine(args.Data + "-> 1\n");
					await _client.PushAsync("chat/", new
					{
						name = "someone",
						text = "Console 1:" + DateTime.Now.ToString("f")
					});
				},
				(sender, args, context) => { System.Console.WriteLine(args.Data); },
				(sender, args, context) => { System.Console.WriteLine(args.Path); });

			var response = await _client.OnAsync("chat",
				(sender, args, context) => { System.Console.WriteLine(args.Data + " -> 2\n"); },
				(sender, args, context) => { System.Console.WriteLine(args.Data); },
				(sender, args, context) => { System.Console.WriteLine(args.Path); });

			//Call dispose to stop listening for events
			//response.Dispose();
		}
	}
}
