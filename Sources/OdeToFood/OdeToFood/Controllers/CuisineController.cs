using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OdeToFood.Filters;

namespace OdeToFood.Controllers
{
    public class CuisineController : Controller
    {
        [Log]
        public ActionResult Search(string name)
        {
            throw new Exception("Something terrible has happend");
            var message = Server.HtmlEncode(name);
            return Json(new {Message = name, Name = "Viorel"}, JsonRequestBehavior.AllowGet);
        }

    }
}
