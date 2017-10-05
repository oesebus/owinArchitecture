using System;
using System.Net.Http;
using Microsoft.Owin.Hosting;

namespace Kenzardi.ConsoleHost
{
	static class MainClass
	{
		public static void Main(string[] args)
		{
			string baseAddress = "http://localhost:9000/";

			//Start OWIN host 
			using (WebApp.Start<Startup>(url: baseAddress))
			{
				HttpClient client = new HttpClient();
				var response = client.GetAsync(baseAddress + "api/values/").Result;
				Console.WriteLine($"Kenzardi API started on URL : {baseAddress}");
				Console.WriteLine(response.Content.ReadAsStringAsync().Result);
				Console.ReadLine();
			}
		}
	}
}