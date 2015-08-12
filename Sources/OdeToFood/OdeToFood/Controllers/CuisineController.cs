using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OdeToFood.Filters;

namespace OdeToFood.Controllers
{
    [Log]
    public class CuisineController : Controller
    {
        //
        // GET: /Cuisine/
        [HttpPost]
        public ActionResult Search(string name = "french")
        {
            return Content(name);
        }

        public ActionResult About()
        {
            ViewBag.Message = "This is a test message";
            return View();
        }
    }
}
