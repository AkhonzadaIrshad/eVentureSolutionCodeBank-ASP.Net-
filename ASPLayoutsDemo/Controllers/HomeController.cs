using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClassLibrary1DEl;

namespace ASPLayoutsDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            TempContext context=new TempContext();
            List<Person> persons = null;
            using (context)
            {
               persons=context.Persons.Include(x=>x.Address.City.Country).ToList();
            }

            ViewBag.AllPersons = persons;
            //ViewData["persons"] = persons;

            return View();
        }



        [HttpGet]
        public ActionResult ShowDetail(int id)
        {

            TempContext context=new TempContext();

            Person person = null;
            using (context)
            {
                person=(from p in context.Persons
                        .Include(x=>x.Address.City.Country)
                        where p.PersonId==id
                        select p).FirstOrDefault();

            }

            ViewBag.PersonDetail = person;

            return PartialView("_DetailView");
        }

    }
}