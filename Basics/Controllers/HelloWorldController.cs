using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Basics.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/
        /*public string Index() //step1
        {
            return "This is my default action...";
        }
        */
        //string döndürmek gibi view diyerek html gibi bir page döndürülebilir

        public IActionResult Index() //step2
        {
            return View();
        }
        // 
        // GET: /HelloWorld/Welcome/
        /*
        public string Welcome(string name = "Ece", int x = 4, int y = 2)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, x/y={x / y}");
        }
        public string Welcome2(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }
       Burada direkt html formatında bir string döndürmesini sağlıyorduk
        Peki view() şeklinde dönmesini istersem neler olacak?
        */    
    public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }
    }
 }
