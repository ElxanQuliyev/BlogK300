using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace Blogs_K300.Controllers
{
    public class MainLangController : Controller
    {
        // GET: MainLang
        public ActionResult Language(string lang)
        {
            if (lang != null)
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(lang);
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(lang);
            }
            else
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("az");
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("az");
            }
            Response.Cookies.Add(new HttpCookie("K300")
            {
                Value = lang
            });
            return RedirectToAction("Index","Home");
        }
    }
}