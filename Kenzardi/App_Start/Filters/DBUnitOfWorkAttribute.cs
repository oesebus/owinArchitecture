using System.Net.Http;
using System.Web.Http.Filters;
using StackExchange.Redis;

namespace Kenzardi.Filters
{
	public class DbUnitOfWorkAttribute : ActionFilterAttribute
	{
		public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
		{
			var _database = actionExecutedContext.Request.GetDependencyScope()
											   .GetService(typeof(IDatabaseAsync)) as IDatabaseAsync;

			if (_database != null && actionExecutedContext.Exception == null)
			{

			}

			base.OnActionExecuted(actionExecutedContext);
		}
	}
}
