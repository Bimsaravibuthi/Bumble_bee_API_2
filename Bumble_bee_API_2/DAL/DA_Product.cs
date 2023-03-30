using Bumble_bee_API_2.Database;
using Bumble_bee_API_2.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace Bumble_bee_API_2.DAL
{
    public class DA_Product
    {
        private readonly DatabaseContext _connection = new();
        public List<tbl_Product> GetProduct(int? productId)
        {
            List<tbl_Product> Products = new();

            try
            {
                var result = _connection.tbl_Products?.FromSqlRaw("GetProduct {0}", productId).ToList();
                if (result != null)
                {
                    foreach (var item in result)
                    {
                        tbl_Product tbl_Product = new();
                        tbl_Product.PR_ID = item.PR_ID;
                        tbl_Product.PR_NAME = item.PR_NAME;
                        tbl_Product.PR_DESCRIPTION = item.PR_DESCRIPTION;
                        tbl_Product.PR_PRICE = item.PR_PRICE;
                        tbl_Product.BRAND = item.BRAND;
                        tbl_Product.CATEGORY = item.CATEGORY;
                        tbl_Product.PR_COST = item.PR_COST;
                        tbl_Product.PR_QTY = item.PR_QTY;
                        tbl_Product.PR_ADDED_DATE = item.PR_ADDED_DATE;
                        tbl_Product.PR_ADDED_USER = item.PR_ADDED_USER;
                        tbl_Product.PR_IMAGE = item.PR_IMAGE;
                        Products.Add(tbl_Product);
                    }
                    return Products;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An exception occurred: " + ex.Message);
            }
            return new List<tbl_Product>();
        }
        public int AddProduct(tbl_Product pr)
        {
            int OPState = 0;
            try
            {
                if (pr.PR_NAME != null && pr.PR_DESCRIPTION != null && pr.PR_PRICE != null && pr.BRAND != null && pr.CATEGORY != null
                && pr.PR_COST != null && pr.PR_IMAGE != null)
                {
                    OPState = _connection.Database.ExecuteSqlRaw("AddProduct {0},{1},{2},{3},{4},{5},{6},{7},{8},{9}",
                    pr.PR_NAME, pr.PR_DESCRIPTION, pr.PR_PRICE, pr.BRAND.BR_ID, pr.CATEGORY.CAT_ID, pr.PR_COST, pr.PR_QTY, pr.PR_ADDED_DATE,
                    pr.PR_ADDED_USER, pr.PR_IMAGE);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An exception occurred: " + ex.Message);
            }
            return OPState;
        }
        public int PatchProduct(tbl_UserProduct tbl_UserProduct, JsonPatchDocument tbl_Product)
        {
            int OPState = 0;
            var product = _connection.tbl_Products?.Find(tbl_UserProduct.PRODUCT_ID);
            
            if(product != null)
            {
                tbl_Product.ApplyTo(product);
                _connection.tbl_UserProducts?.Add(tbl_UserProduct);
                OPState = _connection.SaveChanges();               
            }
            return OPState;
        }
        public int UpdateProduct(tbl_Product pr, int userId, string updateDesc)
        {
            int OPState = 0;

            if (pr.PR_NAME != null && pr.PR_DESCRIPTION != null && pr.PR_PRICE != null && pr.BRAND != null && pr.CATEGORY != null
                && pr.PR_COST != null && pr.PR_IMAGE != null)
            {
                OPState = _connection.Database.ExecuteSqlRaw("UpdateProduct {0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11}",
                pr.PR_NAME, pr.PR_DESCRIPTION, pr.PR_PRICE, pr.BRAND.BR_ID, pr.CATEGORY.CAT_ID, pr.PR_COST, pr.PR_QTY, pr.PR_IMAGE, pr.PR_ID, userId, DateTime.Now, updateDesc);
            }
            return OPState;
        }
    }
}
