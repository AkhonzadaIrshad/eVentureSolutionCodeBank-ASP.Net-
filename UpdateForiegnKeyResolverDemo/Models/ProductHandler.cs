using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace UpdateForiegnKeyResolverDemo.Models
{
    public class ProductHandler : ICRUD<Product>
    {
        public void Add(Product t)
        {
            AppContext context = new AppContext();
            using (context)
            {
                context.Entry(t.Category).State = EntityState.Unchanged;
                context.Products.Add(t);
                context.SaveChanges();
            }
        }

        public List<Product> Get()
        {
            AppContext context = new AppContext();
            using (context)
            {
                return (from p in context.Products
                        .Include(p => p.Category)
                        select p).ToList();
            }
        }

        public Product Get(int id)
        {
            AppContext context = new AppContext();
            using (context)
            {
                return (from p in context.Products.
                        Include(p => p.Category)
                        where p.Id == id
                        select p).FirstOrDefault();
            }
        }

        public void Update(Product t)
        {
            AppContext context = new AppContext();
            using (context)
            {
                context.Entry(t).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}