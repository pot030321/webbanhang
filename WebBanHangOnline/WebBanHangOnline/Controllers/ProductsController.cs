using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanHangOnline.Models;

namespace WebBanHangOnline.Controllers
{
    public class ProductsController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: Products
        public ActionResult Index(int? id)
        {
            var items= db.products.ToList();
            if (id != null)
            {
               items =items.Where(x => x.ProductCategoryID == id).ToList();
            }
            
            return View(items);
        }
        public ActionResult Detail (string alias,int id)
        {
            var item = db.products.Find(id);
            return View(item);
        }
        public ActionResult ProductCategory(string alias,int id)    
        {
            var items = db.products.ToList();
            if (id >0)
            {
                items = items.Where(x => x.ProductCategoryID == id).ToList();
            }
            var cate = db.productCategories.Find(id);
            if(cate != null)
            {
                ViewBag.CateName = cate.Title;
            }
            ViewBag.CateId = id;

            return View(items);
        }

        public ActionResult Partial_ItemsByCateId() {
            var items = db.products.Where(x=>x.IsHome&&x.IsActive).Take(12).ToList();
            return PartialView(items);
        }
        public ActionResult Partial_ProductSales()
        {
            var items = db.products.Where(x => x.IsActive&&x.IsSale).Take(12).ToList();
            return PartialView(items);
        }
    }
}