using System.Threading.Tasks;
using Order.Interface;
using Product.Interface;
using Product.Model;

namespace Order.Service
{
	public class OrderService : IOrder
	{

		public OrderService()
		{

		}

		public Task<ProductModel> GetProducts()
		{
			return Task.FromResult(new ProductModel()
			{

			});
		}

	}
}
