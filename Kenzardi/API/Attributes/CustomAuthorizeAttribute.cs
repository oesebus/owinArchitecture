using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Attributes
{
	public class CustomAuthorizeAttribute : AuthorizeAttribute
	{
		public override void OnAuthorization(System.Web.Http.Controllers.HttpActionContext actionContext)
		{
			if (AuthorizeRequest(actionContext))
			{
				return;
			}
			HandleUnauthorizedRequest(actionContext);
		}


		protected override void HandleUnauthorizedRequest(System.Web.Http.Controllers.HttpActionContext actionContext)
		{
			//Code to handle unauthorized request
			actionContext.Response.Headers.Add("AuthenticationStatus", "NotAuthorized");
			actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Forbidden);
			return;
		}

		private bool AuthorizeRequest(System.Web.Http.Controllers.HttpActionContext actionContext)

		{
			var token = actionContext.Request.Headers.Authorization.Parameter;
			return false; //Return true if token match with stored one 
		}
	}
}
