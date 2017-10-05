using System.Web.Http;
using Kenzardi.DependencyResolver.StructureMap;
using Kenzardi.Filters;
using Kenzardi.Registries;
using Microsoft.Owin;
using Owin;
using Pipeline;
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

			config.Filters.Add(new CustomValidateModelAttribute());
			config.Filters.Add(new DbUnitOfWorkAttribute());

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
