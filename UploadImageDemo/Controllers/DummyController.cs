using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UploadImageDemo.Controllers
{
    public class DummyController : Controller
    {
        // GET: Dummy
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Upload()
        {
            foreach (string f in Request.Files)
            {
                HttpPostedFileBase file = Request.Files[f];
                if (file != null)
                {
                    string fileName = file.FileName;
                    file.SaveAs(Request.MapPath("~/Content/Images/" + fileName));
                }
            }
            ViewBag.Message = "Successfully Uploaded";
            return View("Index");
        }
    }
}