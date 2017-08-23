using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTempDel
{
    public class Student:Person
    {


        private int rollNumber;
        
        public int RollNumber
        {
            get { return rollNumber; }
            set
            {
                if (value > 0 && value < 1000)
                {
                    rollNumber = value;
                }
            }
        }
        



    }
}
