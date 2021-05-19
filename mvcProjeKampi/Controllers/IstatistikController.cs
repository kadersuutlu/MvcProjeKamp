using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcProjeKampi.Controllers
{
    public class IstatistikController : Controller
    {
        // GET: Istatistik
        Context context = new Context();
        public ActionResult Index()
        {
            var result = context.Categories.Count();
            var result1 = context.Headings.Count(x => x.Category.CategoryName == "Yazılım");
            var result2 = context.Writers.Count(x => x.WriterName.Contains("a"));
            var result3 = context.Headings.Max(x => x.Category.CategoryName);
            var result4 = context.Categories.Count((x => x.CategoryStatus == true));
            var result5 = context.Categories.Count((x => x.CategoryStatus == false));
            ViewBag.CategoryCount = result;
            ViewBag.Heading = result1;
            ViewBag.Writer = result2;
            ViewBag.HeadingMax = result3;
            ViewBag.StatusFark = result4 - result5;

            return View();

        }
    }
}