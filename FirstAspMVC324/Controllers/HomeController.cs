using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstAspMVC324.Models;

namespace FirstAspMVC324.Controllers
{
    public class HomeController : Controller
    {
        // GET: Hoem
        public ActionResult Index()
        {


            //ViewBag.ButtonText = "This is Button From Server";
            //ViewData["message"] = "MESSAGE FROM SOMEWHERE";
            //TempData["message"] = "";

            string message = (string)TempData["message"];
            if (message != null)
            {
                ViewBag.Message = message;
            }




            return View();
        }


        public ActionResult SomeMethod(string ClientData)
        {


            TempData["message"] = ClientData;


            return RedirectToAction("Index");
        }






        [HttpGet]
        public ActionResult LoginDemo()
        {





            return View();
        }
        //[HttpPost]
        //public ActionResult LoginDemo(string username,string password)
        //{


        //    ViewBag.Message = $"Welcome {username} your password is {password}";


        //    return View();
        //}
        public ActionResult LoginDemo(LoginViewModel user)
        {
            
            ViewBag.Message = $"Welcome {user.UserName} your password is {user.Password}";


            return View();
        }





    }
}