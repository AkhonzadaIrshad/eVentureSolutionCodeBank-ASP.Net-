using System;
using System.Collections.Generic;
using System.Linq;

namespace UpdateForiegnKeyResolverDemo.Models
{
    public class CategoryHandler : ICRUD<Category>
    {
        public void Add(Category t)
        {
            AppContext context = new AppContext();
            using (context)
            {
                context.Categories.Add(t);
                context.SaveChanges();
            }
        }

        public List<Category> Get()
        {
            AppContext context = new AppContext();
            using (context)
            {
                return (from c in context.Categories
                        select c).ToList();
            }
        }

        public Category Get(int id)
        {
            AppContext context = new AppContext();
            using (context)
            {
                return (from c in context.Categories
                        where c.Id == id
                        select c).FirstOrDefault();
            }
        }

        public void Update(Category t)
        {
            throw new NotImplementedException();
        }
    }
}