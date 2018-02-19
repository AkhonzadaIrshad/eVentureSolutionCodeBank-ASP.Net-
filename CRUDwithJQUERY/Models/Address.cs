using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDwithJQUERY.Models
{
    public class Address
    {
        [Key]
        [ForeignKey("Person")]
        public int Id { get; set; }

        public Person Person { get; set; }



        private string street;

        public string Street
        {
            get { return street; }
            set { street = value; }
        }




        //public int CityId { get; set; }
        public virtual City City { get; set; }

    }
}
