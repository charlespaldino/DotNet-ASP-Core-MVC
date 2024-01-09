using ExploreCalifornia.Data;
using ExploreCalifornia.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace ExploreCalifornia.Components
{
    [ViewComponent]
    public class TriviaFactsViewComponent : ViewComponent
    {
        private readonly ExploreDBContext explorer_dbcontext;

        public TriviaFactsViewComponent(ExploreDBContext explorer_dbcontext)
        {
            this.explorer_dbcontext = explorer_dbcontext;
        }

        public IViewComponentResult Invoke()
        {
            //Reseed when deleting facts from the database.
            int number = new Random().Next(1, explorer_dbcontext.TriviaFacts.Count()+1);
            return View(explorer_dbcontext.TriviaFacts.Where(x => x.ID == number).First());
        }
    }
}
