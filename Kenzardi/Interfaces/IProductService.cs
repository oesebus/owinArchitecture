using System;
using System.Threading.Tasks;
using Product.Model;

namespace Interfaces
{
	public interface IProductService
	{
		Task<ProductModel> GetProductByIdAsync(Guid id);
		Task<ProductModel> GetProductsAsync(Func<object, Boolean> predicate);
		Task<ProductModel> SaveProductAsync(ProductModel model);
		Task<bool> DeleteAsync(Guid id, string reason = "N/A");

	}
}
