using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstDayWithASPMVC.ClassLibrary
{
    public class Student
    {

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }




        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string fatherName;

        public string FatherName
        {
            get { return fatherName; }
            set { fatherName = value; }
        }

    }
}