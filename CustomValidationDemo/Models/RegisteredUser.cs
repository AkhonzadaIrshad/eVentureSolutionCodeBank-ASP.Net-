using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomValidationDemo.Models
{
    public class RegisteredUser
    {
        private static List<User> users;

        public static List<User> Users
        {
            get { return users; }
            set { users = value; }
        }

        static  RegisteredUser()
        {
            users=new List<User>();
        }
    }
}
