﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BussinesLayer.Concrete;
using DataAccesLayer.Concrecte;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;

namespace MvcProjeKampi.Controllers
{
    public class GalleryController : Controller
    {
        ImageFileManager ifm = new ImageFileManager(new EfImageFileDal());
        // GET: Gallery
        public ActionResult Index()
        {
            var file = ifm.GetList();
            return View(file);
        }
        [HttpGet]
        public ActionResult ImageAdd()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ImageAdd(ImageFile p)
        {
            if(Request.Files.Count>0)
            {
                string fileName = Path.GetFileName(Request.Files[0].FileName);
                string expansion = Path.GetExtension(Request.Files[0].FileName);
                string path = "/AdminLTE-3.0.4/images/"+fileName+ expansion;
                Request.Files[0].SaveAs(Server.MapPath(path));
                p.ImagePath= "/AdminLTE-3.0.4/images/" + fileName + expansion;
                ifm.Add(p);
                return RedirectToAction("Index");
                
            }
            return View();

        }
    }
}