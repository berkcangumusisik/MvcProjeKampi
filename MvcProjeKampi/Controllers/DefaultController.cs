using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BussinesLayer.Concrete;
using DataAccesLayer.EntityFramework;

namespace MvcProjeKampi.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        HeadingManager headingManager = new HeadingManager(new EfHeadingDal());
        ContentManager contentManager = new ContentManager(new EfContentDal());

        // GET: Default
        public ActionResult Headings()
        {
            var result = headingManager.GetList();
            return View(result);
        }
        public PartialViewResult Index(int id = 0)
        {
            var result = contentManager.GetListByHeadingID(id);
            return PartialView(result);
        }
        public ActionResult SweetAlert()
        {
            return View();
        }
    }
}