 
using System.Net;
using System.Web;
using System.Web.Mvc;
using SessionDemo.Models;

namespace SessionDemo.Controllers
{
    public class DefaultController : Controller
    {
        public ActionResult Index()
        {
            LoginUserModel user = (LoginUserModel)Session[SessionHelper.USER];

          

           



            if (user == null) return RedirectToAction("Login");
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            LoginUserModel user = (LoginUserModel)Session[SessionHelper.USER];
            if (user == null) return View();
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult Login(LoginUserModel userModel)
        {
            if (userModel.Password == "Admin")
            {
                Session.Add(SessionHelper.USER, userModel);

                 

                return RedirectToAction("Index", "Default");
            }
            ViewBag.NotFound = "Password is Wrong";
            return View();
        }
    }
}