using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace FirstDayWithASPMVC.ClassLibrary
{
    public class TempContext:DbContext
    {


        public TempContext():base("name=TempConn")
        {
            
        }



        public DbSet<Student> Students { get; set; }




    }
}
