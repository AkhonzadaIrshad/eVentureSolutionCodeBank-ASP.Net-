using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using LayoutsSectionsInMVC.Models;

namespace LayoutsSectionsInMVC.Controllers
{
    public class SecondController : Controller
    {
        public ViewResult Method()
        {



            return View();

        }


        [HttpGet]
        public ActionResult Login()
        {

            ViewBag.Message = "Complete This Form";

            return View();

        }

        //[HttpPost]
        //public ActionResult Login(string UserName, string Password)
        //{

        //    ViewBag.Message = $" Your From Data {UserName} and {Password}";
        //    return View();
        //}
        //[HttpPost]
        //public ActionResult Login(FormCollection formdata)
        //{

        //    ViewBag.Message = $" Your From Data {formdata["UserName"]} and {formdata["Password"]} via FormCollection";
        //    return View();
        //}
        //[HttpPost]
        //public ActionResult Login(User user)
        //{

        //    ViewBag.Message = $" Your From Data {user.UserName} and {user.Password} via Object";
        //    return View();
        //}

        [HttpPost]
        public ActionResult Login(User user)
        {
            ViewBag.Message = $" Your From Data {user.UserName} and {user.Password} via Object (Begin Form)";
            return View();
        }




    }
}
