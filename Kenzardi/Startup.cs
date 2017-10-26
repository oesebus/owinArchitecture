using System.Web.Http;
using Kenzardi.Core;
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
			//config.Filters.Add(new DbUnitOfWorkAttribute());


			IContainer container = new Container(ct =>
			{
				ct.AddRegistry(new WebRegistry());
				ct.AddRegistry(new CoreRegistry());
			});

			config.DependencyResolver = new StructureMapDependencyResolver(container);


			app.UseStructureMapMiddleware(new StructureMapMiddlewareOptions());
			app.UseAuthenticationMiddleware(new AuthenticationMiddlewareOptions());
			app.UseLogMiddleware(new LogMiddlewareOptions());

			//app.UseGoogleAuthentication(new GoogleOAuth2AuthenticationOptions()
			//{
			//	ClientId = "ABC.apps.googleusercontent.com",
			//	ClientSecret = "XYZ"
			//});
			app.UseWebApi(config);
		}

	}
}
