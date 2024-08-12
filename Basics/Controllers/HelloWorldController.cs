using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Basics.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/
        public string Index()
        {
            return "This is my default action...";
        }
        // 
        // GET: /HelloWorld/Welcome/ 
        public string Welcome(string name = "Ece", int x = 4, int y = 2)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, x/y={x / y}");
        }
        public string Welcome2(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }
    }
}