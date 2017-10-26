using Product.Interface;
using StructureMap;

namespace Kenzardi.Registries
{
	public class WebRegistry : Registry
	{
		public WebRegistry()
		{
			For<IProductService>().Use<Product.Service.ProductService>();
		}
	}
}
