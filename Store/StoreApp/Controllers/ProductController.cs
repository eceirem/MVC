using Microsoft.AspNetCore.Mvc;
using Entities.Models;
using Repositories;
using Repositories.Contracts;
using Services.Contracts;

namespace StoreApp.Controllers
{
    public class ProductController : Controller
    {
		//RepositoryContextin bir kaydı varsa kendisi newliyor ve oluşturuyor
		//artık bir IRepoManager ile çalışıyoruz bir soytulama işlemi yapıyoruz
		//private readonly IRepositoryManager _manager;
		//yukarıdaki ifadeyi istemiyorum çünkü repop değil service ile ileitişim kuracağım
		private readonly IServiceManager _manager;

		public ProductController(IServiceManager manager)
        {
			_manager = manager;
        }

        public IActionResult Index()
        {
            //1.adım
            //burada ürünlerim direkt liste şeklinde döner
            //return new List<Product>()
            //{
            //    new Product(){ProductId=1,ProductName="Computer",ProductPrice=45000}
            //};
            //2.adım verilerin veri tabanından gelmesini istiyorum.
            //veriler context'de bu yüzden oraya gidiyorum
            //var context = new RepositoryContext(
            //    new DbContextOptionsBuilder<RepositoryContext>() benden options tipi istiyor
            //    .UseSqlite("Data Source=./ProductDb.db")
            //    .Options);          
            //3.adım dependency injection DI
            //return _context.Products; 
            //yukarıdaki ifade sayesinde bu işlemi yapabilirim
            //view ile dönmesini istiyorum öncesinde ise manager ile ulaşım sağlıyorum
            var model = _manager.ProductService.GetAllProducts(false);
            return View(model);
        }
        //bu fonksiyon ile sadece tek bir veriye id üzerinden ulaşım sağlayacağım
        //endpointlerle oynamalar yapılabilir bu yüzden daha temiz tanım lazım
        //bu yüzden FromRoute kullanıyoruz
        public IActionResult Get([FromRoute(Name="id")]int id)
        {
            //direkt databaseden veri çekiyoruz.
            //Product product = _context.Products.First(p => p.ProductId.Equals(id));
            //return View(product);
            //verileri bir Product repositoryden çekiyorduk ancak artık service var.
            //bu yüzden Product. ile ulaşmaktansa ProcutService ile ulaşabilirim
            var model = _manager.ProductService.GetOneProduct(id, false);
            return View(model);
        }
    }
}
