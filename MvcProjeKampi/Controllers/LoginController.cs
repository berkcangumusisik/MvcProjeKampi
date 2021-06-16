using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using BussinesLayer.Abstract;
using BussinesLayer.Concrete;
using DataAccesLayer.Concrecte;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;
using EntityLayer.Dto;

namespace MvcProjeKampi.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        IAuthService authService = new AuthManager(new AdminManager(new EfAdminDal()));

        Context context = new Context();
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(LoginDto loginDto)
        {

            if (authService.Login(loginDto))
            {
                FormsAuthentication.SetAuthCookie(loginDto.AdminUserName, false);
                Session["AdminUserName"] = loginDto.AdminUserName;
                return RedirectToAction("Index", "AdminCategory");
            }
            else
            {
                ViewData["ErrorMessage"] = "Kullanıcı adı veya Parola yanlış";
                return View();
            }

        }
        public ActionResult LogOut()
        {
            //Session.Abandon();
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Login");
        }
        [HttpGet]
        public ActionResult WriterLogin()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult WriterLogin(Writer p)
        {
            Context c = new Context();
            var writeruserinfo = c.Writers.FirstOrDefault(x => x.WriterMail == p.WriterMail && x.WriterPassword == p.WriterPassword);
            if (writeruserinfo !=null)
            {
                FormsAuthentication.SetAuthCookie(writeruserinfo.WriterMail, false);
                Session["WriterMail"] = writeruserinfo.WriterMail;
                return RedirectToAction("MyContent", "WriterPanelContent");
            }
            else
            {
                ViewData["ErrorMessage"] = "Kullanıcı adı veya Parola yanlış";
                return View();
            }
        }
    }

}
