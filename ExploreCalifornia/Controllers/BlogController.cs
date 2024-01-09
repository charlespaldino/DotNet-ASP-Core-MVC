using ExploreCalifornia.Code;
using ExploreCalifornia.Data;
using ExploreCalifornia.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace ExploreCalifornia.Controllers
{
    [Route("Blog")]
    public class BlogController : Controller
    {
        private readonly ExploreDBContext explorer_dbcontext;
        private readonly int DEFAULT_PAGE_SIZE = 5;

        public BlogController(ExploreDBContext explorer_dbcontext)
        {
            this.explorer_dbcontext = explorer_dbcontext; 
        }

        [Route("")]
        public IActionResult Index(int page = 0)
        {
            updatePaging(page);
            Post[] posts = explorer_dbcontext.Posts.OrderByDescending(post => post.Posted)
                .Skip(DEFAULT_PAGE_SIZE * page).Take(DEFAULT_PAGE_SIZE).ToArray();

            //Check Jquery for ajax call
            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
            {
                return PartialView(posts);
            }

            return View(posts);
        }

        [Route("{year:min(2000)}/{month:range(1,12)}/{key}")]
        public IActionResult Post(int year, int month, String key)
        {
            Post blog_post = explorer_dbcontext.Posts.FirstOrDefault(x => x.ID + "" == key);

            return View(blog_post);
        }

        [Authorize]
        [HttpGet, Route("create")]
        public IActionResult Create()
        {
            return View();
        }

        [Authorize]
        [HttpPost, Route("create")]
        public IActionResult Create(Post post)
        {
            if(!ModelState.IsValid){return View();}

            post.Author = User.Identity.Name;
            post.Posted = DateTime.Now;

            explorer_dbcontext.Add(post);
            explorer_dbcontext.SaveChanges();

            return RedirectToAction("Post", "Blog", new
            {
                year = post.Posted.Year,
                month = post.Posted.Month,
                key = post.ID
            });

        }

        private void updatePaging(int page)
        {
            ViewBag.PreviousPage = page - 1;
            ViewBag.HasPreviousPage = page > 0;
            ViewBag.NextPage = page + 1;
            ViewBag.HasNextPage = ViewBag.NextPage <= explorer_dbcontext.Posts.Count() / DEFAULT_PAGE_SIZE;
        }



    }
}
