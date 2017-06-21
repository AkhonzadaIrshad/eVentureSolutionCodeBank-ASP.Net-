using System;
using System.Web.Mvc;
using AjaxImplementationDemos.Models;

namespace AjaxImplementationDemos.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        //Simple call no parameters
        [HttpGet]
        public ActionResult SimpleCall()
        {
            return PartialView("_SimpleCall");
        }

        //Call with single parameter defined in Route Info
        [HttpGet]
        public ActionResult WithRouteParameters(string id)
        {
            return PartialView("_WithRouteParameters");
        }

        //Call with multiple parameters in query string 
        [HttpPost]
        public ActionResult WithQueryString(string stringOne,string stringTwo)
        {
            return PartialView("_WithQueryString");
        }

        //Call with jSon Object 
        [HttpPost]
        public ActionResult WithJsonObject(dynamic jsonObject)
        {
            return PartialView("_WithJsonObject");
        }

        //Sending and Receiving jSon Object (Auto Serialization)
        [HttpPost]
        public ActionResult WithSendingAndReceivinJsonObject(User user)
        {
            if (user!=null)
            {
                return Json(user);
            }
            return Json("Ajax Response Failed");
        }

    }
}