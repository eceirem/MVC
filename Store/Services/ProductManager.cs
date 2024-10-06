using AutoMapper;
using Entities.Dtos;
using Entities.Models;
using Repositories.Contracts;
using Services.Contracts;

namespace Services
{
	public class ProductManager : IProductService
	{
		private readonly IRepositoryManager _manager;
		private readonly IMapper _mapper;
		
		public ProductManager(IRepositoryManager manager, IMapper mapper)
		{
			_manager = manager;
			_mapper = mapper;
		}

		public ProductManager(IRepositoryManager manager)
		{
			_manager = manager;	
		}
		IEnumerable<Product> IProductService.GetAllProducts(bool trackChanges)
		{
			return _manager.Product.GetAllProducts(trackChanges);
		}

		public Product? GetOneProduct(int id, bool trackChanges)
		{
			var product = _manager.Product.GetOneProduct(id, trackChanges);
			if (product == null)
			{
				throw new Exception("Product not found!");
			}
			return product;
		}
		public void CreateProduct(ProductDtoForInsertion productDto)
		{
			Product product = _mapper.Map<Product>(productDto);			
			_manager.Product.Create(product);
			_manager.Save();
		}

		public void DeleteOneProduct(int id)
		{
			Product product = GetOneProduct(id, false);
			if(product is not null)
			{
				_manager.Product.DeleteOneProduct(product);
				_manager.Save();
			}
		}

		public void UpdateOneProduct(ProductDtoForUpdate productDto)
		{
			//var entity = _manager.Product.GetOneProduct(productDto.ProductId, true);
			//entity.ProductName = productDto.ProductName;
			//entity.ProductPrice = productDto.ProductPrice;
			//entity.CategoryId = productDto.CategoryId;
			var entity = _mapper.Map<Product>(productDto);
			_manager.Product.UpdateOneProduct(entity);
			_manager.Save();
		}

		public ProductDtoForUpdate GetOneProductForUpdate(int id, bool trackChanges)
		{
			var product = GetOneProduct(id, trackChanges);
			return _mapper.Map<ProductDtoForUpdate>(product);
		}
	}
}