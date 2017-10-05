using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstAPSMVCApplication.Models;
namespace FirstAPSMVCApplication.Controllers
{
    public class FirstController : Controller
    {
        public void FirstMethod()
        {
            
        }
        public string SecondMethod()
        {
            return "Second MVC Method";
        }

        public ViewResult ThirdMethod()
        {

           // ViewBag.FirstViewBag = "Evs Lahore";
           ViewBag.FirstObject=new FirstClass()
           {
               FirstName = "ABC",
               FirstRollNumber = 11,
               SecondName = "XYZ"
           };

            return View();
        }


    }
}