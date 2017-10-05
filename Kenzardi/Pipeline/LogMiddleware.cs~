using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Owin;
using AppFunc = System.Func<System.Collections.Generic.IDictionary<string, object>, System.Threading.Tasks.Task>;

namespace Pipeline
{
	public class LogMiddleware
	{

		AppFunc _next;
		LogMiddlewareOptions _options;
		public LogMiddleware(AppFunc next, LogMiddlewareOptions options)
		{
			_next = next;
			_options = options;
			if (_options.OnIncomingRequest == null)
				_options.OnIncomingRequest = (ctx) => { Console.WriteLine($"Incoming request :{ctx.Request.Path}"); };

			if (_options.OnOutGoingRequest == null)
				_options.OnOutGoingRequest = (ctx) => { Console.WriteLine($"Outgoing request :{ctx.Request.Path}"); };

		}

		public async Task Invoke(IDictionary<string, object> env)
		{
			var ctx = new OwinContext(env);
			_options.OnIncomingRequest(ctx);
			await _next(env);
			_options.OnOutGoingRequest(ctx);
		}
	}
}
