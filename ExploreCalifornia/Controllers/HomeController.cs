using Microsoft.AspNetCore.Mvc;

namespace ExploreCalifornia.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("/About")]
        public IActionResult About()
        {
            return View();
        }

        [Route("/Mission")]
        public IActionResult Mission()
        {
            return View();
        }

        [Route("/Resources")]
        public IActionResult Resources()
        {
            return View();
        }
    }
}
