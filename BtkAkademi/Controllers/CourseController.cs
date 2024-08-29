using Microsoft.AspNetCore.Mvc;
using BtkAkademi.Models;
namespace BtkAkademi.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Apply()
        {
            return View();
        }
         
        [HttpPost]
        [ValidateAntiForgeryToken]
        //verinin nereden geldiğini belirtmekte fayda varmış
        public IActionResult Apply([FromForm] Candidates model)
        {
            return View();
        }
    }
}
    
