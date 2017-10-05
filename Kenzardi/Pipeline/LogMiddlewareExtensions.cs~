using System;
using Kenzardi.Pipeline;
using Owin;

namespace Pipeline
{
	public static class LogMiddlewareExtensions
	{
		public static void UseLogMiddleware(this IAppBuilder app, LogMiddlewareOptions options)
		{
			if (options == null)
			{
				options = new LogMiddlewareOptions();
				app.Use<LogMiddleware>(options);
			}
		}
	}
}
