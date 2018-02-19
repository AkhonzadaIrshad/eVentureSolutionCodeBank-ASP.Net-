using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDoPs.Models
{
    public class CRUDContext:DbContext
    {
        public CRUDContext():base("name=CRUDConn")
        {
            
        }


        public DbSet<Student> Students { get; set; }
        public DbSet<Address> Addresses { get; set; }



    }
}
