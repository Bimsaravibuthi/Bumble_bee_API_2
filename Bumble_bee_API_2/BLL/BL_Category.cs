using Bumble_bee_API_2.DAL;
using Bumble_bee_API_2.Database;
using Bumble_bee_API_2.Models;
using Microsoft.AspNetCore.JsonPatch;

namespace Bumble_bee_API_2.BLL
{
    public class BL_Category
    {
        DA_Category _dA_Category = new();
        public List<Category> GetCategory(int? categoryId)
        {
            List<Category> categories = new();
            var result = _dA_Category.GetCategory(categoryId);
            foreach (var item in result)
            {
                Category category = new()
                {
                    CAT_ID = item.CAT_ID,
                    CAT_NAME = item.CAT_NAME
                };
                categories.Add(category);
            }
            return categories;
        }
        public object AddCategory(Category category)
        {
            tbl_Category tbl_Category = new()
            {
                CAT_ID = category.CAT_ID,
                CAT_NAME = category.CAT_NAME
            };
            return _dA_Category.AddCategory(tbl_Category);
        }
        public object PatchCategory(int categoryId, JsonPatchDocument tbl_Category)
        {
            return _dA_Category.PatchCategory(categoryId, tbl_Category);
        }
        public object UpdateCategory(Category category)
        {
            tbl_Category tbl_Category = new()
            {
                CAT_ID = category.CAT_ID,
                CAT_NAME = category.CAT_NAME
            };
            return _dA_Category.UpdateCategory(tbl_Category);
        }
    }
}
