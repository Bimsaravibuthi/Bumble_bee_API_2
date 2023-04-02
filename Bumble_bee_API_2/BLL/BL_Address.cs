using Bumble_bee_API_2.DAL;
using Bumble_bee_API_2.Database;
using Bumble_bee_API_2.Models;
using Microsoft.AspNetCore.JsonPatch;

namespace Bumble_bee_API_2.BLL
{
    public class BL_Address
    {
        DA_Address _dA_Address = new();
        public List<Address> GetAddress(int? userId, int? addressId)
        {
            List<Address> tbl_Addresses = new();
            var result = _dA_Address.GetAddress(userId, addressId);
            foreach (var item in result)
            {
                Address address = new();
                address.ADD_ID = item.ADD_ID;
                address.ADD_NAME = item.ADD_NAME;
                address.ADD_MOBILE = item.ADD_MOBILE;
                address.ADD_LINE1 = item.ADD_LINE1;
                address.ADD_LINE2 = item.ADD_LINE2;
                address.CITY = item.CT_ID;
                address.USER = item.USR_ID;
                tbl_Addresses.Add(address);
            }
            return tbl_Addresses;
        }
        public object AddAddress(Address address)
        {
            tbl_Address tbl_Address = new()
            {
                ADD_NAME = address.ADD_NAME,
                ADD_MOBILE = address.ADD_MOBILE,
                ADD_LINE1 = address.ADD_LINE1,
                ADD_LINE2 = address.ADD_LINE2,
                CT_ID = address.CITY,
                USR_ID = address.USER
            };
            return _dA_Address.AddAddress(tbl_Address);
        }
        public object PatchAddress(int addressId, JsonPatchDocument tbl_Address)
        {
            return _dA_Address.PatchAddress(addressId, tbl_Address);
        }
        public object UpdateAddress(Address address)
        {
            tbl_Address tbl_Address = new()
            {
                ADD_ID = address.ADD_ID,
                ADD_NAME = address.ADD_NAME,
                ADD_MOBILE = address.ADD_MOBILE,
                ADD_LINE1 = address.ADD_LINE1,
                ADD_LINE2 = address.ADD_LINE2,
                CT_ID = address.CITY,
                USR_ID = address.USER
            };
            return _dA_Address.UpdateAddress(tbl_Address);
        }
        private tbl_City FindCityByCT_ID(int cityId)
        {
            tbl_City tbl_City = new tbl_City()
            {
                CT_ID = cityId,
            };
            return tbl_City;
        }
        private tbl_User FindUserByUSR_ID(int userId)
        {
            tbl_User tbl_User = new tbl_User()
            {
                USR_ID = userId,
            };
            return tbl_User;
        }
    }
}
