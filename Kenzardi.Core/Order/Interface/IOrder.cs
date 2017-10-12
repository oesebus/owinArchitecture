using System.Threading.Tasks;
using Product.Model;

namespace Order.Interface
{
	public interface IOrder
	{
		Task<ProductModel> GetProducts();

	}
}
