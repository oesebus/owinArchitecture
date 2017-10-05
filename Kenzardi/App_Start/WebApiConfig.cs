using System.Web.Http;

namespace Kenzardi
{
	public static class WebApiConfig
	{
		public static void Register(HttpConfiguration config)
		{
			//Todo avoid system.web dependency
			//config.Routes.MapHttpRoute(
			//	name: "DefaultApi",
			//	routeTemplate: "api/{controller}/{id}",
			//	defaults: new { id = RouteParameter.Optional }
			//);
		}
	}
}
