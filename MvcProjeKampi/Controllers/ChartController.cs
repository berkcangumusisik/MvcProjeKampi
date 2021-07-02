using DataAccesLayer.Concrecte;
using MvcProjeKampi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class ChartController : Controller
    {
        // GET: Chart
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CategoryPieChart()
        {
            return View();
        }

        public ActionResult WriterColumnChart()
        {
            return View();
        }

        public ActionResult TalentLineChart()
        {
            return View();
        }

        public List<CategoryChart> BlogList()
        {
            List<CategoryChart> categoryCharts = new List<CategoryChart>();
            categoryCharts.Add(new CategoryChart()
            {
                CategoryName = "Yazılım",
                CategoryCount = 8
            });
            categoryCharts.Add(new CategoryChart()
            {
                CategoryName = "Seyehat",
                CategoryCount = 4
            });
            categoryCharts.Add(new CategoryChart()
            {
                CategoryName = "Teknoloji",
                CategoryCount = 7
            });
            categoryCharts.Add(new CategoryChart()
            {
                CategoryName = "Spor",
                CategoryCount = 1
            });
            return categoryCharts;
        }

        public ActionResult CategoryChart()
        {
            return Json(BlogList(), JsonRequestBehavior.AllowGet);
        }

        public List<CategoryChart> CategoryList()
        {
            List<CategoryChart> categoryCharts = new List<CategoryChart>();
            using (var context = new Context())
            {
                categoryCharts = context.Categories.Select(c => new CategoryChart
                {
                    CategoryName = c.CategoryName,
                    CategoryCount = c.Headings.Count()
                }).ToList();
            }

            return categoryCharts;
        }

        public ActionResult CategoryCharts()
        {
            return Json(CategoryList(), JsonRequestBehavior.AllowGet);
        }

        public List<WriterChart> WriterList()
        {
            List<WriterChart> writerCharts = new List<WriterChart>();
            using (var context = new Context())
            {
                writerCharts = context.Writers.Select(c => new WriterChart
                {
                    WriterName = c.WriterName,
                    WriterCount = c.Headings.Count()
                }).ToList();
            }

            return writerCharts;
        }

        public ActionResult WriterChart()
        {
            return Json(WriterList(), JsonRequestBehavior.AllowGet);
        }

        public List<TalentChart> TalentList()
        {
            List<TalentChart> talentCharts = new List<TalentChart>();
            using (var context = new Context())
            {
                talentCharts = context.Talents.Select(c => new TalentChart
                {
                    TalentName = c.TalentName,
                    TalentRange = c.Range
                }).ToList();
            }

            return talentCharts;
        }

        public ActionResult TalentChart()
        {
            return Json(TalentList(), JsonRequestBehavior.AllowGet);
        }

    }
}