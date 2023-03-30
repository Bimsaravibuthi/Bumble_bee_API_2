using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bumble_bee_API_2.Migrations
{
    public partial class PDO_UpdateProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sql = @"CREATE PROCEDURE UpdateProduct
                        @pr_name nvarchar(25),
                        @pr_description nvarchar(MAX),
                        @pr_price nvarchar(7),
                        @brand int,
                        @category int,
                        @pr_cost nvarchar(7),
                        @pr_qty int,
                        @pr_image varbinary(MAX),
                        @pr_id int,
                        @update_user int,
                        @update_date datetime2(7),
                        @update_desc nvarchar(MAX)
                        as
                        update tbl_Products set PR_NAME = @pr_name,PR_DESCRIPTION = @pr_description,PR_PRICE = @pr_price,
                        BRANDBR_ID = @brand,CATEGORYCAT_ID = @category,PR_COST = @pr_cost,PR_QTY = @pr_qty,PR_IMAGE = @pr_image
                        where PR_ID = @pr_id;

                        insert into tbl_UserProducts(UPDATE_USER,PRODUCT_ID,UPDATE_DATE,UPDATE_DESC)
                        values(@update_user,@pr_id,@update_date,@update_desc);";
            migrationBuilder.Sql(sql);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
