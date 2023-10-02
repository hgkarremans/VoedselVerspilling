using Microsoft.AspNetCore.Mvc;

namespace VoedselVerspilling.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
