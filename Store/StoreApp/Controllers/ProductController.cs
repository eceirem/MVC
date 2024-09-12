using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StoreApp.Models;

namespace StoreApp.Controllers
{
    public class ProductController : Controller
    {
        //RepositoryContextin bir kaydı varsa kendisi newliyor ve oluşturuyor
        private readonly RepositoryContext _context;

        public ProductController(RepositoryContext context)
        {
            _context = context;
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
            //3.adım
            //return _context.Products; 
            //yukarıdaki ifade sayesinde bu işlemi yapabilirim
            //view ile dönmesini istiyorum
            var model = _context.Products.ToList();
            return View(model);
        }
        //bu fonksiyon ile sadece tek bir veriye id üzerinden ulaşım sağlayacağım
        public IActionResult Get(int id)
        {
            Product product = _context.Products.First(p => p.ProductId.Equals(id));
            return View(product);
        }
    }
}
