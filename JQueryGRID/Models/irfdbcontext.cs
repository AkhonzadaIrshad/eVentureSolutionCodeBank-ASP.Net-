using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JQueryGRID.Models
{
    public class irfdbcontext:DbContext
    {
        public irfdbcontext():base("name=ProgramConnection")
        {
                
        }
        public  DbSet<UserModel> UserModels { get; set; }
    }
}
