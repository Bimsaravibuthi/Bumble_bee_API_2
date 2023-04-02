using Bumble_bee_API_2.DAL;
using Bumble_bee_API_2.Database;
using Bumble_bee_API_2.Models;
using Microsoft.AspNetCore.JsonPatch;

namespace Bumble_bee_API_2.BLL
{
    public class BL_Brand
    {
        DA_Brand _dA_Brand = new();
        public List<Brand> GetBrand(int? brandId)
        {
            List<Brand> brands = new();
            var result = _dA_Brand.GetBrand(brandId);
            foreach(var item in result)
            {
                Brand brand = new()
                {
                    BR_ID = item.BR_ID,
                    BR_NAME = item.BR_NAME
                };
                brands.Add(brand);
            }
            return brands;
        }
        public object AddBrand(Brand brand)
        {
            tbl_Brand tbl_Brand = new()
            {
                BR_ID = brand.BR_ID,
                BR_NAME= brand.BR_NAME
            };
            return _dA_Brand.AddBrand(tbl_Brand);
        }
        public object PatchBrand(int brandId, JsonPatchDocument tbl_Brand)
        {
            return _dA_Brand.PatchBrand(brandId, tbl_Brand);
        }
        public object UpdateBrand(Brand brand)
        {
            tbl_Brand tbl_Brand = new()
            {
                BR_ID = brand.BR_ID,
                BR_NAME = brand.BR_NAME
            };
            return _dA_Brand.UpdateBrand(tbl_Brand);
        }
    }
}
