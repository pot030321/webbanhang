using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanHangOnline.Models;
using PagedList;
using System.Web.Services.Description;

namespace WebBanHangOnline.Areas.Admin.Controllers
{
    public class OrderController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: Admin/Order
        public ActionResult Index(int? page)
        {
            var items = db.orders.OrderByDescending(x => x.CreateDate).ToList();
            if (page == null)
            {
                page = 1;
            }
            var pageNumber = page ?? 1;
            var pageSize = 10;
            ViewBag.PageSize = pageSize;
            ViewBag.PageNumber = pageNumber;
            return View(items.ToPagedList(pageNumber, pageSize));
        }   

        public ActionResult View(int id)
        {
            var item = db.orders.Find(id);
            return View(item);
        }
        [HttpPost]
        public ActionResult UpdateStatus(int  id,int state)
        {
            var item = db.orders.Find(id);
            if(item != null)
            {
                db.orders.Attach(item);
                item.Typepayment = state;
                db.Entry(item).Property(x=>x.Typepayment).IsModified=true;
                db.SaveChanges();
                return Json(new {message = "Success",Success=true });
            }
            return Json(new { message = "UnSuccess", Success = false });
        }
    }
}