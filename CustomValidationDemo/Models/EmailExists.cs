using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomValidationDemo.Models
{
    public class EmailExists:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string email = value.ToString();
            if (RegisteredUser.Users.Where(x=>x.Email.Equals(email,StringComparison.CurrentCultureIgnoreCase)).FirstOrDefault()!=null)
            {
                return new ValidationResult("Email Already Exists");
            }
            return ValidationResult.Success;
        }
    }
}
