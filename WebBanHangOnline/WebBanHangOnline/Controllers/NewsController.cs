using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanHangOnline.Models;

namespace WebBanHangOnline.Controllers
{
    public class NewsController : Controller
    {
        // GET: News
        private ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            var item = db.news.ToList();
            return View(item);
        }
        public ActionResult Detail(int id)
        {
            var item = db.news.Find(id);
            return View(item);
        }
        public ActionResult Partial_News_Home()
        {
            var items = db.news.Take(3).ToList();
            return PartialView(items);
        }
    }
}