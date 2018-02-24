using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JQueryGRID.Models
{
    public class UserModel
    {
        public int Id { get; set; }      
        public string UserName    { get; set; }
        public bool   Gender      { get; set; }
        public int    Country     { get; set; }
        public string Description { get; set; }
     }


    public class UserViewModel
    {

        public List<UserModel> UserModel  { get; set; }
    }
    
}
