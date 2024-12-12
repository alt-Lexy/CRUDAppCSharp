using CRUDAppp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUDAppp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }
    }
}
