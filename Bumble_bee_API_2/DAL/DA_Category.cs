using Bumble_bee_API_2.Database;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;
using static Bumble_bee_API_2.Database.DatabaseContext;

namespace Bumble_bee_API_2.DAL
{
    public class DA_Category
    {
        DatabaseContext _Connection = new();
        StatusCode statusCode = new();
        public List<tbl_Category> GetCategory(int? categoryId)
        {
            List<tbl_Category> tbl_Categories = new();
            try
            {
                var result = _Connection.Tbl_Categories?.FromSqlRaw("GetCategory {0}", categoryId).ToList();
                if (result != null)
                {
                    foreach (var item in result)
                    {
                        tbl_Category tbl_Category = new()
                        {
                            CAT_ID = item.CAT_ID,
                            CAT_NAME = item.CAT_NAME
                        };
                        tbl_Categories.Add(tbl_Category);
                    }
                    return tbl_Categories;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An exception occurred: " + ex.Message);
            }
            return new List<tbl_Category>();
        }
        public StatusCode AddCategory(tbl_Category cat)
        {
            try
            {
                if (cat.CAT_NAME != null)
                {
                    var result = _Connection.statusCodes?.FromSqlRaw("AddCategory {0}", cat.CAT_NAME);
                    if (result != null)
                    {
                        foreach (var item in result)
                        {
                            statusCode = item;
                        }
                        return statusCode;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An exception occurred: " + ex.Message);
            }
            return new StatusCode();
        }
        public StatusCode PatchCategory(int categoryId, JsonPatchDocument tbl_Category)
        {
            try
            {
                var Category = _Connection.Tbl_Categories?.Find(categoryId);
                if (Category != null)
                {
                    tbl_Category.ApplyTo(Category);
                    int result = _Connection.SaveChanges();
                    if (result > 0)
                    {
                        statusCode.STATUS_MSG = "PATCHED SUCCESSFULLY";
                    }
                    else
                    {
                        statusCode.STATUS_MSG = "PATCHING UN-SUCCESSFUL";
                    }
                    return statusCode;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An exception occurred: " + ex.Message);
            }
            return new StatusCode();
        }
        public StatusCode UpdateCategory(tbl_Category cat)
        {
            try
            {
                if (cat.CAT_NAME != null)
                {
                    var result = _Connection.statusCodes?.FromSqlRaw("UpdateCategory {0},{1}", cat.CAT_ID, cat.CAT_NAME);
                    if (result != null)
                    {
                        foreach (var item in result)
                        {
                            statusCode = item;
                        }
                        return statusCode;
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
