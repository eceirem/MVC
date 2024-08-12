using Microsoft.AspNetCore.Mvc;

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
        public string Welcome(string name, int x, int y)
        {
            return $"Hello {name}, x+y={x+y}";
        }
    }
}