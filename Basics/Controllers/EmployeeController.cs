using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Basics.Models;
namespace Basics.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index1()
        {
            string message = $"Hello  World. {DateTime.Now.ToString()}";
            //View içerisine tek argüman yazarsam o adda bir View dosyası arama anlamına geliyor
            //İlk argümanım dosya adı, ikinci argümanım ise taşıdığım bilgi olabilir
            return View("Index1",message);
        }

        public ViewResult Index2()
        {
            var names = new String[]
            {
                "Ahmet",
                "Mehmet",
                "Can",
                "Ece"
            };
            //index2 sayfasını bulduğu için argüman olarak gönderdi
            return View(names);
        }
        //INdex3 ContentResult şeklinde de tanımlanabilir
        //IActionResult daha geniş bir ifade olduğu için bu referansı kullanıyoruz

        public IActionResult Index3()
        {
            var list = new List<Employee>()
            {
                new Employee() {Id= 1, FirstName ="Ahmet", LastName="Yılmaz",Age=20 },
                new Employee() {Id= 2, FirstName ="Ece İrem", LastName="Şişer",Age=21 },
                new Employee() {Id= 3, FirstName ="Çiğdem", LastName="Şişer",Age=46}
            };

			return View("Index3",list);
        }
    }
}
