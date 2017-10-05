using System.Web.Http;
using Filters;
using Microsoft.Owin;
using Owin;
using Pipeline;
using Registries;
using StructureMap;


[assembly: OwinStartup(typeof(Kenzardi.Startup))]
namespace Kenzardi
{
	public class Startup
	{
		public void Configuration(IAppBuilder app)
		{
			var config = new HttpConfiguration();

			config.MapHttpAttributeRoutes();
			config.Filters.Add(new DBUnitOfWorkAttribute());

			ObjectFactory.Initialize(cfg =>
			{
				cfg.AddRegistry(new WebRegistry());
			});


			config.DependencyResolver = new StructureMapDependencyResolver(ObjectFactory.Container);


			app.UseStructureMapMiddleware(new StructureMapMiddlewareOptions());
			app.UseAuthenticationMiddleware(new AuthenticationMiddlewareOptions());
			app.UseLogMiddleware(new LogMiddlewareOptions());
			app.UseWebApi(config);
		}

	}
}
