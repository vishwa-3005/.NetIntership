using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ViewBagDemo.Models;

namespace ViewBagDemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string user = "vishwa";
            ViewData["msg"] = "Hello " + user;
            ViewData["Count"] = 10;
            ViewBag.Count = 20;
            TempData["TempMsg"] = "Good morning !!";
            return RedirectToAction(nameof(Print));
        }

        public IActionResult Print()
        {
            ViewBag.Print = "Hey There....";
            return View();
        }
    }
}
