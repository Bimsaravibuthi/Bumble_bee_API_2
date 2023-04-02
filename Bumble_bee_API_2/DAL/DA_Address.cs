using Bumble_bee_API_2.Database;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;
using static Bumble_bee_API_2.Database.DatabaseContext;

namespace Bumble_bee_API_2.DAL
{
    public class DA_Address
    {
        DatabaseContext _connection = new();
        StatusCode StatusCodes = new();

        public List<tbl_Address> GetAddress(int? userId, int? addressId)
        {
            List<tbl_Address> Addresses = new();

            try
            {
                var result = _connection.Tbl_Addresses?.FromSqlRaw("GetAddress {0},{1}", userId, addressId).ToList();
                if (result != null)
                {
                    foreach (var item in result)
                    {
                        tbl_Address tbl_Address = new()
                        {
                            ADD_ID = item.ADD_ID,
                            ADD_NAME = item.ADD_NAME,
                            ADD_MOBILE = item.ADD_MOBILE,
                            ADD_LINE1 = item.ADD_LINE1,
                            ADD_LINE2 = item.ADD_LINE2,
                            CT_ID = item.CT_ID,
                            USR_ID = item.USR_ID
                        };
                        Addresses.Add(tbl_Address);
                    }
                    return Addresses;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An exception occurred: " + ex.Message);
            }
            return new List<tbl_Address>();
        }
        public StatusCode AddAddress(tbl_Address ad)
        {
            try
            {
                if (ad.ADD_NAME != null && ad.ADD_MOBILE != null && ad.ADD_LINE1 != null && ad.ADD_LINE2 != null)
                {
                    var result = _connection.statusCodes?.FromSqlRaw("AddAddress {0},{1},{2},{3},{4},{5}",
                    ad.ADD_NAME, ad.ADD_MOBILE, ad.ADD_LINE1, ad.ADD_LINE2, ad.CT_ID, ad.USR_ID);
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
        public StatusCode PatchAddress(int addressId, JsonPatchDocument tbl_Address)
        {
            var address = _connection.Tbl_Addresses?.Find(addressId);

            if (address != null)
            {
                tbl_Address.ApplyTo(address);
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
        public StatusCode UpdateAddress(tbl_Address ad)
        {
            try
            {
                if (ad.ADD_NAME != null && ad.ADD_MOBILE != null && ad.ADD_LINE1 != null && ad.ADD_LINE2 != null)
                {
                    var result = _connection.statusCodes?.FromSqlRaw("UpdateAddress {0},{1},{2},{3},{4},{5}",
                    ad.ADD_NAME, ad.ADD_MOBILE, ad.ADD_LINE1, ad.ADD_LINE2, ad.CT_ID, ad.ADD_ID);
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
