using Bumble_bee_API_2.Database;
using Bumble_bee_API_2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using static Bumble_bee_API_2.Database.DatabaseContext;

namespace Bumble_bee_API_2.DAL
{
    public class DA_Product
    {
        private readonly DatabaseContext _connection = new();
        StatusCode StatusCodes = new();
        public List<tbl_Product> GetProduct(int? productId)
        {
            List<tbl_Product> Products = new();
            Console.WriteLine(DateTime.Now);
            try
            {
                var result = _connection.Tbl_Products?.FromSqlRaw("GetProduct {0}", productId).ToList();
                if (result != null)
                {
                    foreach (var item in result)
                    {
                        tbl_Product tbl_Product = new();
                        tbl_Product.PR_ID = item.PR_ID;
                        tbl_Product.PR_NAME = item.PR_NAME;
                        tbl_Product.PR_DESCRIPTION = item.PR_DESCRIPTION;
                        tbl_Product.PR_PRICE = item.PR_PRICE;
                        tbl_Product.BR_ID = item.BR_ID;
                        tbl_Product.CAT_ID = item.CAT_ID;
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
        public StatusCode AddProduct(tbl_Product pr)
        {
            try
            {
                if (pr.PR_NAME != null && pr.PR_DESCRIPTION != null && pr.PR_PRICE != null && pr.PR_COST != null && pr.PR_IMAGE != null)
                {
                    var result = _connection.statusCodes?.FromSqlRaw("AddProduct {0},{1},{2},{3},{4},{5},{6},{7},{8},{9}",
                    pr.PR_NAME, pr.PR_DESCRIPTION, pr.PR_PRICE, pr.BR_ID, pr.CAT_ID, pr.PR_COST, pr.PR_QTY, pr.PR_ADDED_DATE,
                    pr.PR_ADDED_USER, pr.PR_IMAGE);
                    if (result != null)
                    {
                        foreach (var item in result)
                        {
                            StatusCodes = item;
                        }
                        return StatusCodes;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An exception occurred: " + ex.Message);
            }
            return new StatusCode();
        }
        public StatusCode PatchProduct(tbl_UpdateProduct tbl_UpdateProduct, JsonPatchDocument tbl_Product)
        {
            var product = _connection.Tbl_Products?.Find(tbl_UpdateProduct.PR_ID);

            if (product != null)
            {
                tbl_Product.ApplyTo(product);
                _connection.Tbl_UpdateProducts?.Add(tbl_UpdateProduct);
                int result = _connection.SaveChanges();
                if (result > 0)
                {
                    StatusCodes.STATUS_MSG = "PATCHED SUCCESSFULLY";
                }
                else
                {
                    StatusCodes.STATUS_MSG = "PATCHING UN-SUCCESSFUL";
                }
            }
            return StatusCodes;
        }
        public StatusCode UpdateProduct(tbl_Product pr, int userId, string updateDesc)
        {
            try
            {
                if (pr.PR_NAME != null && pr.PR_DESCRIPTION != null && pr.PR_PRICE != null && pr.PR_COST != null && pr.PR_IMAGE != null)
                {
                    var result = _connection.statusCodes?.FromSqlRaw("UpdateProduct {0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11}",
                    pr.PR_NAME, pr.PR_DESCRIPTION, pr.PR_PRICE, pr.BR_ID, pr.CAT_ID, pr.PR_COST, pr.PR_QTY, pr.PR_IMAGE, pr.PR_ID, userId, DateTime.Now, updateDesc);
                    if (result != null)
                    {
                        foreach (var item in result)
                        {
                            StatusCodes = item;
                        }
                        return StatusCodes;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An exception occurred: " + ex.Message);
            }
            return new StatusCode();
        }
    }
}
