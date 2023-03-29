using Bumble_bee_API_2.DAL;
using Bumble_bee_API_2.Database;
using Bumble_bee_API_2.Models;

namespace Bumble_bee_API_2.BLL
{
    public class BL_Product
    {             
        public List<Product> GetProduct(int? productId)
        {
            DA_Product _dA_Product = new();

            List<Product> tbl_Products = new();
            var result = _dA_Product.GetProduct(productId);
            foreach(var item in result) 
            {
                Product product= new Product();
                product.PR_ID = item.PR_ID;
                product.PR_NAME = item.PR_NAME;
                product.PR_DESCRIPTION = item.PR_DESCRIPTION;
                product.PR_PRICE = item.PR_PRICE;
                product.BRAND = Convert.ToInt32(item.BRAND);
                product.CATEGORY = Convert.ToInt32(item.CATEGORY);
                product.PR_COST = item.PR_COST;
                product.PR_QTY = item.PR_QTY;  
                product.PR_ADDED_DATE = item.PR_ADDED_DATE;
                product.PR_ADDED_USER = item.PR_ADDED_USER;
                product.PR_IMAGE = item.PR_IMAGE;               
                tbl_Products.Add(product);
            }

            if(tbl_Products != null)
            {
                return tbl_Products;
            }
            return new List<Product>();
        }
    }
}
