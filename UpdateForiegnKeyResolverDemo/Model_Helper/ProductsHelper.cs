using System.Collections.Generic;
using UpdateForiegnKeyResolverDemo.Models;
using UpdateForiegnKeyResolverDemo.View_Models;

namespace UpdateForiegnKeyResolverDemo.Model_Helper
{
    public class ProductsHelper
    {
        public static List<ProductModel> ProductsToProductModels(List<Product> products)
        {
            List<ProductModel> productModels = null;
            if (products != null)
            {
                productModels = new List<ProductModel>();
                foreach (var item in products)
                {
                    productModels.Add(new ProductModel()
                    {
                        Id = item.Id,
                        Name = item.Name,
                        Category = item.Category.Id,

                        CategoryList = CommonHelper.ToDropDownList(
                                       CommonHelper.ToDropDownList(
                                       new CategoryHandler().Get()), item.Category.Id)
                    });
                }
            }
            return productModels;
        }

        public static ProductModel ProductToProductModel(Product product)
        {
            ProductModel productModel = null;
            if (product != null)
            {
                productModel = new ProductModel()
                {
                    Id = product.Id,
                    Name = product.Name,
                    Category = product.CategoryId,
                    CategoryList = CommonHelper.ToDropDownList(
                                   CommonHelper.ToDropDownList(
                                   new CategoryHandler().Get()), product.Category.Id)
                };
            }
            return productModel;
        }
    }
}