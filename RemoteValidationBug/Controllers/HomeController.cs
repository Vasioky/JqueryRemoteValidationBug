using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RemoteValidationBug.Controllers
{
    public class HomeController : Controller
    {
        [HttpPost]
        public ActionResult Save(SaveModel model)
        {
            if (model.PostAction == null)
            {
                throw new NullReferenceException("PostAction");
            }
            return null;
        }

        public JsonResult Remote(string name)
        {
            return Json(true, JsonRequestBehavior.AllowGet);
        }
    }

    public class SaveModel
    {
        public string Name { get; set; }

        public string PostAction { get; set; }
    }
}