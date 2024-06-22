using AllUp_Project.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AllUp_Project.Controllers
{
    public class HomeController : Controller
    {
      
        public IActionResult Index()
        {
            return View();
        }
    }
}