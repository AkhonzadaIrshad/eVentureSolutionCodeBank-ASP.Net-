using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUDoPs.Models;
using CRUDoPs.ViewModels;

namespace CRUDoPs.Mappers
{
    public class StudentMapper
    {
        public static Student ModelToContext(StudentModel model)
        {
            return new Student()
            {
                Id = model.Id,
                Address = new Address()
                {
                    Street = model.Street
                },
                Email = model.Email,
                Name = model.Name
            };

        }
        public static StudentModel ContextToModel(Student context)
        {
            return new StudentModel()
            {
                Id = context.Id,
                Street = context.Address.Street,
                Email = context.Email,
                Name = context.Name
            };

        }
    }
}
