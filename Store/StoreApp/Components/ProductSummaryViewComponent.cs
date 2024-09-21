using Microsoft.AspNetCore.Mvc;
using Repositories;
using Services.Contracts;

namespace StoreApp.Components
{
	public class ProductSummaryViewComponent : ViewComponent
	{
        //Repository dirrekt kullanmak mantıklı değil 
        //çünkü veritabanında olan her içerik satışta olmayabilir
        //private readonly RepositoryContext _context;
        private readonly IServiceManager _manager;

        public ProductSummaryViewComponent(IServiceManager manager)
		{
			_manager = manager;
		}

		public string Invoke()
		{
			return _manager.ProductService.GetAllProducts(false).Count().ToString();
			//return _context.Products.Count().ToString();
		}
	}
}
