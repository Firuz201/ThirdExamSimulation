using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace ThirdExamSimulation.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
