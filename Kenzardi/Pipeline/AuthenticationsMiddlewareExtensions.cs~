using System;
using Kenzardi.Pipeline;
using Owin;

namespace Pipeline
{
	public static class AuthenticationsMiddlewareExtensions
	{
		public static void UseAuthenticationMiddleware(this IAppBuilder app, AuthenticationMiddlewareOptions options)
		{
			if (options == null)
			{
				options = new AuthenticationMiddlewareOptions();
				app.Use<AuthenticationMiddleware>(options);
			}
		}
	}
}
