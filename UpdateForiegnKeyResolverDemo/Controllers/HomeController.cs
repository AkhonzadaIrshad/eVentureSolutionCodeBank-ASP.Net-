using System.Web.Mvc;
using UpdateForiegnKeyResolverDemo.Model_Helper;
using UpdateForiegnKeyResolverDemo.Models;
using UpdateForiegnKeyResolverDemo.View_Models;

namespace UpdateForiegnKeyResolverDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Categories = CommonHelper.ToDropDownList(new CategoryHandler().Get());
            ViewBag.Products = ProductsHelper.ProductsToProductModels(new ProductHandler().Get());
            return View();
        }

        [HttpPost]
        public ActionResult Add(ProductModel product)
        {
            if (product.Id == 0)
            {
                new ProductHandler().Add(new Product()
                {
                    Category = new CategoryHandler().Get(product.Category),
                    Name = product.Name
                });
            }
            else
            {
                new ProductHandler().Update(new Product()
                {
                    Id = product.Id,
                    CategoryId = new CategoryHandler().Get(product.Category).Id,
                    Name = product.Name
                });
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            ProductModel product = ProductsHelper.ProductToProductModel(new ProductHandler().Get(id));
            ViewBag.Products = ProductsHelper.ProductsToProductModels(new ProductHandler().Get());
            return View(product);
        }
    }
}