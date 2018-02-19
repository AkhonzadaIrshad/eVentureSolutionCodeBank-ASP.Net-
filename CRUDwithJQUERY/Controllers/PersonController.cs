using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRUDwithJQUERY.Models;
using CRUDwithJQUERY.ViewModels;

namespace CRUDwithJQUERY.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {


            List<SelectListItem> cityList = new List<SelectListItem>();
            foreach (var city in new CrudContext().Cities.ToList())
            {
                cityList.Add(new SelectListItem()
                {
                    Text = city.Name,
                    Value = city.Id.ToString()
                });

            }

            ViewBag.Cities = cityList;



           // ViewBag.Persons = ;
            return View();
        }


        [HttpPost]
        public ActionResult AddPerson(PersonModel personModel)
        {

            try
            {

                using (CrudContext db = new CrudContext())
                {
                    var teacher = new Teacher()
                    {
                        Address = new Address()
                        {
                            Street = personModel.Street,
                            City = new City()
                            {
                                Id = personModel.CityId,
                               // CountryId = 1
                            }

                        },
                        Name = personModel.Name,
                        Email = personModel.Email
                    };
                    db.Entry(teacher.Address.City).State=EntityState.Unchanged;
                    db.Persons.Add(teacher);
                    db.SaveChanges();
                   return Json(true, JsonRequestBehavior.AllowGet);

                }





            }
            catch(Exception ex)
            {
                return Json(ex.Message, JsonRequestBehavior.AllowGet);
            }


        }
    }
}