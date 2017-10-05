using System;
using System.Web.Http.Controllers;
using System.Web.Http.ModelBinding;

namespace ModelBinders
{
	public class ProductBinder : IModelBinder
	{
		public ProductBinder()
		{

		}

		public bool BindModel(HttpActionContext actionContext, ModelBindingContext bindingContext)
		{
			throw new NotImplementedException();
		}
	}
}
