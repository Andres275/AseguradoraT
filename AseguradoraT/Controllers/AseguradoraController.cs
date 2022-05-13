using AseguradoraT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace AseguradoraT.Controllers
{
    public class AseguradoraController : Controller
    {
       public ActionResult View_Aseguradora()
        {
            List<Aseguradora> oAseguradora = new List<Aseguradora>();
            return View(oAseguradora);
        }
        [HttpPost]
        public JsonResult Save(Aseguradora oAseguradora)
        {
            oAseguradora.Save(oAseguradora);
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            String json = serializer.Serialize(oAseguradora);
            return Json(json, JsonRequestBehavior.AllowGet);
        }

    }
}