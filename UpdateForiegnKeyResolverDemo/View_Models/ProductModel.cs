using System.Collections.Generic;
using System.Web.Mvc;

namespace UpdateForiegnKeyResolverDemo.View_Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Category { get; set; }
        public List<SelectListItem> CategoryList { get; set; }
    }
}