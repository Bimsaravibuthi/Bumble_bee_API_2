using Bumble_bee_API_2.Database;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;
using static Bumble_bee_API_2.Database.DatabaseContext;

namespace Bumble_bee_API_2.DAL
{
    public class DA_Brand
    {
        DatabaseContext _Connection = new();
        StatusCode statusCode = new();

        public List<tbl_Brand> GetBrand(int? brandId)
        {
            List<tbl_Brand> tbl_Brands= new();
            try
            {
                var result = _Connection.Tbl_Brands?.FromSqlRaw("GetBrand {0}", brandId).ToList();
                if (result != null)
                {
                    foreach (var item in result)
                    {
                        tbl_Brand tbl_Brand = new()
                        {
                            BR_ID = item.BR_ID,
                            BR_NAME = item.BR_NAME
                        };
                        tbl_Brands.Add(tbl_Brand);
                    }
                    return tbl_Brands;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("An exception occurred: " + ex.Message);
            }
            return new List<tbl_Brand>();
        }
        public StatusCode AddBrand(tbl_Brand br)
        {
            try
            {
                if (br.BR_NAME != null)
                {
                    var result = _Connection.statusCodes?.FromSqlRaw("AddBrand {0}", br.BR_NAME);
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
            catch(Exception ex)
            {
                Console.WriteLine("An exception occurred: " + ex.Message);
            }
            return new StatusCode();
        }
        public StatusCode PatchBrand(int brandId, JsonPatchDocument tbl_Brand)
        {
            try
            {
                var Brand = _Connection.Tbl_Brands?.Find(brandId);
                if(Brand != null)
                {
                    tbl_Brand.ApplyTo(Brand);
                    int result = _Connection.SaveChanges();
                    if(result > 0) 
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
            catch(Exception ex)
            {
                Console.WriteLine("An exception occurred: " + ex.Message);
            }
            return new StatusCode();
        }
        public StatusCode UpdateBrand(tbl_Brand br)
        {
            try
            {
                if(br.BR_NAME != null)
                {
                    var result = _Connection.statusCodes?.FromSqlRaw("UpdateBrand {0},{1}",br.BR_ID,br.BR_NAME);
                    if(result != null)
                    {
                        foreach(var item in result)
                        {
                            statusCode = item;
                        }
                        return statusCode;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("An exception occurred: " + ex.Message);
            }
            return new StatusCode();
        }
    }
}
