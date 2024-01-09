using ExploreCalifornia.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace ExploreCalifornia.Components
{
    [ViewComponent]
    public class MonthlySpecialsViewComponent : ViewComponent
    {
        private readonly ExploreDBContext explorer_dbcontext;

        public MonthlySpecialsViewComponent(ExploreDBContext explorer_dbcontext)
        {
            this.explorer_dbcontext = explorer_dbcontext;  
        }

        public IViewComponentResult Invoke()
        {
            return View(explorer_dbcontext.MonthlySpecials.ToArray().OrderByDescending(special => special.Price));
        }
    }
}
