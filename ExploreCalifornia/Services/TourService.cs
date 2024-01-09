using ExploreCalifornia.Data;
using ExploreCalifornia.Models.Tours;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ExploreCalifornia.Services
{
    public class TourService
    {
        private ExploreDBContext explorer_dbcontext { get; set; }
        public TourService(ExploreDBContext context)
        {
            explorer_dbcontext = context;
        }

        public List<Tour> getTours()
        {
            return explorer_dbcontext.Tours.ToList();
        }
    }
}
