using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcToDo.Controllers
{
    public class ToDoListController : Controller
    {
 
        public IActionResult Index()
        {
            return View();
        }
        // 
        // GET: /HelloWorld/Welcome/ 
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            return View();

            //            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }
    }
}
