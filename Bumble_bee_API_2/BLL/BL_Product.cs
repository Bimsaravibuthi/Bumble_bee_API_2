﻿using Bumble_bee_API_2.DAL;
using Bumble_bee_API_2.Database;
using Bumble_bee_API_2.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace Bumble_bee_API_2.BLL
{
    public class BL_Product
    {
        DA_Product _dA_Product = new();
        public List<Product> GetProduct(int? productId)
        {            
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
            return tbl_Products;
        }
        public int AddProduct(Product product)
        {
            tbl_Product tbl_Product = new()
            {
                PR_NAME = product.PR_NAME,
                PR_DESCRIPTION = product.PR_DESCRIPTION,
                PR_PRICE = product.PR_PRICE,
                BRAND = FindBrandByBR_ID(product.BRAND),
                CATEGORY = FindCategoryByCAT_ID(product.CATEGORY),
                PR_COST = product.PR_COST,
                PR_QTY = product.PR_QTY,
                PR_ADDED_DATE = product.PR_ADDED_DATE,
                PR_ADDED_USER = product.PR_ADDED_USER,
                PR_IMAGE = product.PR_IMAGE
            };
            int OPState = _dA_Product.AddProduct(tbl_Product);
            return OPState;
        }
        public int PatchProduct(int productId, int userId, string updateDesc, JsonPatchDocument tbl_Product)
        {
            tbl_UserProduct tbl_UserProduct = new tbl_UserProduct
            {
                UPDATE_USER = userId,
                PRODUCT_ID = productId,
                UPDATE_DATE = DateTime.Now,
                UPDATE_DESC = updateDesc
            };
            int OPState = _dA_Product.PatchProduct(tbl_UserProduct, tbl_Product);
            return OPState;
        }
        public int UpdateProduct(Product product, int userId, string updateDesc)
        {
            tbl_Product tbl_Product = new()
            {
                PR_ID = product.PR_ID,
                PR_NAME = product.PR_NAME,
                PR_DESCRIPTION = product.PR_DESCRIPTION,
                PR_PRICE = product.PR_PRICE,
                BRAND = FindBrandByBR_ID(product.BRAND),
                CATEGORY = FindCategoryByCAT_ID(product.CATEGORY),
                PR_COST = product.PR_COST,
                PR_QTY = product.PR_QTY,
                PR_IMAGE = product.PR_IMAGE
            };
            int OPState = _dA_Product.UpdateProduct(tbl_Product, userId, updateDesc);
            return OPState;
        }
        private tbl_Brand FindBrandByBR_ID(int brandId)
        {
            tbl_Brand tbl_Brand = new tbl_Brand()
            {
                BR_ID = brandId,
            };
            return tbl_Brand;
        }
        private tbl_Category FindCategoryByCAT_ID(int categoryId) 
        {
            tbl_Category tbl_Category = new tbl_Category()
            {
                CAT_ID = categoryId,
            };
            return tbl_Category;
        }
    }
}
