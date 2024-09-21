using Entities.Models;
using Repositories.Contracts;
using Services.Contracts;

namespace Services
{
	public class ProductManager : IProductService
	{
		private readonly IRepositoryManager _manager;
		
		public ProductManager(IRepositoryManager manager)
		{
			_manager = manager;	
		}
		IEnumerable<Product> IProductService.GetAllProducts(bool trackChanges)
		{
			return _manager.Product.GetAllProducts(trackChanges);
		}

		Product? IProductService.GetOneProduct(int id, bool trackChanges)
		{
			var product = _manager.Product.GetOneProduct(id, trackChanges);
			if (product == null)
			{
				throw new Exception("Product not found!");
			}
			return product;
		}
	}
}