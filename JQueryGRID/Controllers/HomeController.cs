using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JQueryGRID.Models;

namespace JQueryGRID.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Save(UserViewModel UserViewModel)
        {


            irfdbcontext db = new irfdbcontext();
            db.UserModels.AddRange(UserViewModel.UserModel);
            db.SaveChanges();

            return RedirectToAction("Index");


        }
    }
}