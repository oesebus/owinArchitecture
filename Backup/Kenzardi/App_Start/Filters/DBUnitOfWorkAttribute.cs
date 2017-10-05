using System;
using System.Net.Http;
using System.Web.Http.Filters;

namespace Filters
{
	public class DBUnitOfWorkAttribute : ActionFilterAttribute
	{
		public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
		{
			//var session = actionExecutedContext.Request.GetDependencyScope()
			//	.GetService(typeof()) as IDocumentSession;

			//if (session != null && actionExecutedContext.Exception == null)
			//{
			//	session.SaveChanges();
			//}

			base.OnActionExecuted(actionExecutedContext);
		}
	}
}
