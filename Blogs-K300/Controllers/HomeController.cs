using Blogs_K300.Models;
using Blogs_K300.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blogs_K300.Controllers
{
    public class HomeController : Controller
    {
        BlogDB db;
        public HomeController()
        {
            db= new BlogDB();
        }
        public ActionResult Index(int? id)
        {
            List<Product> prList=null;
            if (id == null)
                prList = db.Products.OrderByDescending(pr => pr.Id).Where(pr => pr.Language.CultureCode == mLang.lb).Take(6).ToList();
            else
                prList = db.Products.Where(pr => pr.CategoryId == id && pr.Language.CultureCode == mLang.lb).OrderByDescending(pr => pr.Id).Take(6).ToList();
            var vm = new AllVm
            {
                CategoryList = db.Categories.Where(ct=>ct.Language.CultureCode==mLang.lb).ToList(),
                Product = prList
            };
            return View(vm);
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