using System.Diagnostics;
using ClassLibrary;
using Microsoft.AspNetCore.Mvc;

namespace DatabaseDevelopment.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() => View(new Error { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier } );
    }
}