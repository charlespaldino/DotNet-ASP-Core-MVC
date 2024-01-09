using ExploreCalifornia.Data;
using ExploreCalifornia.Models.Tours;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ExploreCalifornia.Controllers
{
    public class TourController : Controller
    {
        private readonly ExploreDBContext explorer_dbcontext;

        public TourController(ExploreDBContext explorer_dbcontext)
        {
            this.explorer_dbcontext = explorer_dbcontext;
        }

        public IActionResult Index()
        {
            foreach (var item in explorer_dbcontext.Tours)
            {
                explorer_dbcontext.Entry(item).Collection(x => x.TourDetails).Load();
            }
            return View(explorer_dbcontext.Tours);
        }

        [Route("/Details")]
        public IActionResult Details(int ID)
        {
            Tour tour = explorer_dbcontext.Tours.Where(x => x.ID == ID).FirstOrDefault();

            explorer_dbcontext.Entry(tour).Collection(x => x.TourDetails).Load();
            tour.TourDetails.ToList().ForEach(details => explorer_dbcontext.Entry(details).Reference(x => x.TourInfo).Load());

            return View(tour);
        }

        [Route("/Details/Info")]
        public IActionResult Info(int ID, int details_ID)
        {
            Tour tour = explorer_dbcontext.Tours.Where(x => x.ID == ID).FirstOrDefault();
            explorer_dbcontext.Entry(tour).Collection(x => x.TourDetails).Load();
            
            TourDetail details = tour.TourDetails.Where(x => x.ID == details_ID).FirstOrDefault();
            explorer_dbcontext.Entry(details).Reference(x => x.TourInfo).Load();

            return View(details);
        }
    }
}
