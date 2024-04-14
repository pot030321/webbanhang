using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanHangOnline.Models;
using WebBanHangOnline.Models.EF;

namespace WebBanHangOnline.Controllers
{
  
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();   
        
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Partial_Subcribe()
        {
            return PartialView();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Subcribe(Subscribe request)
        {
            if (ModelState.IsValid)
            {
                db.subscribes.Add(new Subscribe { Email=request.Email,CreatedDate = DateTime.Now});
                db.SaveChanges();
                return Json(new {Success=true});
            }
            return View("Partial_Subcribe");
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}