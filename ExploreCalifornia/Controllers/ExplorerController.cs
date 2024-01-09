using Microsoft.AspNetCore.Mvc;

namespace ExploreCalifornia.Controllers
{
    public class ExplorerController : Controller
    {
       

        public IActionResult Index()
        {
            return View();
        }

       
    }
}
