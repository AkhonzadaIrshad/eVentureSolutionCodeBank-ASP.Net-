using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRUDoPs.Mappers;
using CRUDoPs.Models;
using CRUDoPs.ViewModels;

namespace CRUDoPs.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {



            var students = new CRUDContext().Students.Include(x => x.Address).ToList();
            //(from s in new CRUDContext().Students.Include(x => x.Address)
            //    select s).ToList();

            List<StudentModel> studentModels = new List<StudentModel>();
            foreach (Student s in students)
            {
                studentModels.Add(StudentMapper.ContextToModel(s));
            }

            ViewBag.Students = studentModels;

            return View();
        }



        [HttpPost]
        public ActionResult Register(StudentModel studentModel)
        {
            try
            {


                CRUDContext db = new CRUDContext();
                if (studentModel.Id > 0)
                {

                    Student student = db.Students.Include(x=>x.Address).Where(x=>x.Id==studentModel.Id).FirstOrDefault();
                    student.Email = studentModel.Email;
                    student.Name = studentModel.Name;



                    db.Entry(student).State = EntityState.Modified;
                }
                else
                {
                    db.Students.Add(StudentMapper.ModelToContext(studentModel));
                }
                db.SaveChanges();
                var students = new CRUDContext().Students.Include(x => x.Address).ToList();
                List<StudentModel> studentModels = new List<StudentModel>();
                foreach (Student s in students)
                {
                    studentModels.Add(StudentMapper.ContextToModel(s));
                }

                return Json(studentModels, JsonRequestBehavior.AllowGet);
               
            }
            catch(Exception e)
            {
                return Json(e.Message, JsonRequestBehavior.AllowGet);
            }

            return Json(false, JsonRequestBehavior.AllowGet);
        }
    }
}