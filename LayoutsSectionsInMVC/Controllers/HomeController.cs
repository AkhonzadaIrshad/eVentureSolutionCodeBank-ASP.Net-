//using EFDemo1.CodeFirst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication6.Models;

namespace WebApplication6.Controllers
{


  

    public class HomeController : Controller
    {
        // GET: Home

        public ActionResult MainPage()
        {
            return View();
        }

        public ActionResult Products()
        {
            List<Product> All = new List<Product>()
            {
                new Product(){
                Image="~/Content/temp/i1.jpg",
                Name="First",
                Price=1000,
                },
                new Product(){
                Image="~/Content/temp/i2.jpg",
                Name="First",
                Price=2000,
                },
                 new Product(){
                Image="~/Content/temp/i3.jpg",
                Name="First",
                Price=3000,
                },
                  new Product(){
                Image="~/Content/temp/i4.jpg",
                Name="First",
                Price=4000,
                }
            };

            //User abc = new User();

            ViewBag.TopProduct = new Product()
            {
                Image = "~/Content/temp/i1.jpg",
                Name = "First",
                Price = 1000,
            };


            return View(All);
        }
        public ActionResult Product(int id)
        {
            return View();
        }

        public ActionResult ContactUs()
        {
            return View();
        }

        public ActionResult LogIn()
        {
            return PartialView("~/Views/Home/_ProductView.cshtml");
        }



    }
}