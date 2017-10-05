using System;
using Microsoft.Owin;

namespace Pipeline
{
	public class AuthenticationMiddlewareOptions
	{
		public Action<IOwinContext> OnIncomingRequest;
		public Action<IOwinContext> OnOutGoingRequest;

		public AuthenticationMiddlewareOptions()
		{
		}
	}
}
