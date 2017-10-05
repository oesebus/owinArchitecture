using System.Web.Http.Filters;

namespace Kenzardi.Filters
{
	public class DbUnitOfWorkAttribute : ActionFilterAttribute
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
