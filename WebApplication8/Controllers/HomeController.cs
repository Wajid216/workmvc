using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication8.Controllers
{
    public class HomeController : Controller
    {

        w3css_templates_clothing_storeEntities db = new w3css_templates_clothing_storeEntities();
        public ActionResult Index()
        {
            var product = db.Products.ToList();
            ViewBag.products = product;
            return View();
        }
        public ActionResult Category()
        {
            var category = db.Categories.ToList();
            ViewBag.categoirs = category;
            return View();
        }
        public ActionResult GetPro(int CategoryId)
        {
            var product = db.Products.Where(p => p.CategoryId == CategoryId).ToList();
            ViewBag.products = product;
            return View("Index");
        }
        public ActionResult Sub(Subcribe obj)
        {
            db.Subcribes.Add(obj);
            db.SaveChanges();
            return View("Index");
        }
        public ActionResult Tbl(Subcribe obj)
        {
            db.Subcribes.Add(obj);
            db.SaveChanges();
            return View("Index");
        }
	}
}