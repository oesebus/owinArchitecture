using System;
using Microsoft.Owin;

namespace Pipeline
{
	public class LogMiddlewareOptions
	{
		public Action<IOwinContext> OnIncomingRequest;
		public Action<IOwinContext> OnOutGoingRequest;

		public LogMiddlewareOptions()
		{
		}
	}
}
