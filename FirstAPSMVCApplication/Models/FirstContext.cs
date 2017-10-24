using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAPSMVCApplication.Models
{
    public class FirstContext:DbContext
    {


        public FirstContext():base("name=FirstConn")
        {
            
        }


        public DbSet<FirstClass> FirstClasses { get; set; }

        
    }
}
