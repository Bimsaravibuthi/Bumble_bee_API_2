﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bumble_bee_API_2.DAL
{
    public class tbl_Product
    {
        [Key]
        public int PR_ID { get; set; }
        [Column(TypeName = "nvarchar(25)")]
        [Required]
        public string? PR_NAME { get; set; }
        [Column(TypeName = "nvarchar(MAX)")]
        [Required]
        public string? PR_DESCRIPTION { get; set; }
        [Column(TypeName = "nvarchar(7)")]
        [Required]
        public string? PR_PRICE { get; set; }
        [Column(TypeName = "nvarchar(7)")]
        [Required]
        public string? PR_COST { get; set; }
        public int PR_QTY { get; set; }
        public ICollection<tbl_UserProduct>? tbl_UserProducts { get; set; }
        public tbl_Brand? BRAND { get; set; }
        public tbl_Category? CATEGORY { get; set; }
    }
}