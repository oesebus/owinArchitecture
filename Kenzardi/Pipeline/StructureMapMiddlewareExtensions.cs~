using System;
using Owin;

namespace Pipeline
{
	public static class StructureMapMiddlewareExtensions
	{
		public static void UseStructureMapMiddleware(this IAppBuilder app, StructureMapMiddlewareOptions options)
		{
			if (options == null)
			{
				options = new StructureMapMiddlewareOptions();
				app.Use<StructureMapMiddleware>(options);
			}
		}
	}
}
