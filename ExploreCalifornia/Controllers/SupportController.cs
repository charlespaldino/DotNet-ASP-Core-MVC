using ExploreCalifornia.Data;
using ExploreCalifornia.Models;
using ExploreCalifornia.Models.Support;
using ExploreCalifornia.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace ExploreCalifornia.Controllers
{
    public class SupportController : Controller
    {

        private readonly ExploreDBContext explorer_dbcontext;
        private readonly TourService tour_service;

        public SupportController(ExploreDBContext explorer_dbcontext)
        {
            tour_service = new TourService(explorer_dbcontext);
            this.explorer_dbcontext = explorer_dbcontext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Tours = explorer_dbcontext.Tours;

            return View();
        }

        [Route("QuickSupport")]
        [HttpPost]
        public IActionResult QuickSupport()
        {
            if (!ModelState.IsValid) { return View("Index"); }

            //Send out email if we had SMTP hooked up.
            ViewBag.EmailSent = true;
            ViewBag.Tours = explorer_dbcontext.Tours;

            return View("Index");
        }

        [Route("ContactUs")]
        [HttpGet]
        public IActionResult ContactUs()
        {
            SupportForm form = new SupportForm() { RequestedTourInfo = new List<RequestedTourInfoViewModel>()};
            tour_service.getTours().ToList().ForEach(tour =>
            {
                form.RequestedTourInfo.Add(new RequestedTourInfoViewModel
                {
                    Name = tour.Name,
                    Id = tour.ID
                });
            });

            return View(form);
        }

        [HttpPost, Route("ContactUs")]
        public IActionResult ContactUs(SupportForm support_form)
        {
            if (!ModelState.IsValid) { return View("ContactUs"); }

            //Send out email if we had SMTP hooked up.
            ViewBag.EmailSent = true;
            ModelState.Clear();

            return View("ContactUs");
        }

    }
}
