using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDwithJQUERY.Models
{
    public class Person
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
        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public virtual Address Address { get; set; }
    }
}
