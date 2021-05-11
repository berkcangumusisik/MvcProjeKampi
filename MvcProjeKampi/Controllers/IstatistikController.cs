using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAccesLayer.Concrecte;

namespace MvcProjeKampi.Controllers
{
    public class IstatistikController : Controller
    {
        Context context = new Context();
        // GET: Istatistik
        public ActionResult Index()
        {
            var result = context.Categories.Count();
            var result2 = context.Headings.Count( x => x.Category.CategoryId==7);
            var result3 = context.Writers.Count(x => x.WriterName.Contains("a"));
            var result4 = context.Headings.Max(x => x.Category.CategoryName);
            var result5 = context.Categories.Count(x => x.CategoryStatus == true);
            var result6 = context.Categories.Count(x => x.CategoryStatus == false);
            ViewBag.CategoryCount = result;
            ViewBag.Heading = result2;
            ViewBag.Writer = result3;
            ViewBag.HeadingMax = result4;
            ViewBag.StatusFark = (result5-result6);
            
            return View();
        }
    }
}