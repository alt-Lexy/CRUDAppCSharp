using Microsoft.AspNetCore.Mvc;

namespace CRUDAppp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }

        public string Connexion()
        {
            return "page de connexion";
        }
    }
}
