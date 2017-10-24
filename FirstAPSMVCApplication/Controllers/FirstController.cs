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


        [HttpGet]
        public ViewResult ThirdMethod()
        {

           // ViewBag.FirstViewBag = "Evs Lahore";

            FirstContext db=new  FirstContext();


            ViewBag.FirstObject = db.FirstClasses.ToList();

            return View();
        }

        [HttpPost]
        public ViewResult ThirdMethod(FirstClass obj)
        {
            //ViewBag.FirstObject = obj;

            try
            {
                FirstContext db=new FirstContext();
                db.FirstClasses.Add(obj);
                db.SaveChanges();
                ViewBag.Message = "Successfully Added";

            }
            catch (Exception e)
            {
                ViewBag.Message = $"Something Went Wrong Details {e.Message}";
                return View();
            }



            return View();

        }


    }
}