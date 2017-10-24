using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CustomValidationDemo.Models;

namespace CustomValidationDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                RegisteredUser.Users.Add(user);
            }
            return View();
        }
    }
}