using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bumble_bee_API_2.Migrations
{
    public partial class PDO_AddProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sql = @"CREATE PROCEDURE AddProduct
                        @pr_name nvarchar(25),
                        @pr_description nvarchar(MAX),
                        @pr_price nvarchar(7),
                        @brand int,
                        @category int,
                        @pr_cost nvarchar(7),
                        @pr_qty int,
                        @pr_added_date datetime2(7),
                        @pr_added_user int,
                        @pr_image varbinary(MAX)
                        as
                        insert into tbl_Products(PR_NAME,PR_DESCRIPTION,PR_PRICE,BRANDBR_ID,CATEGORYCAT_ID,PR_COST,PR_QTY,PR_ADDED_DATE,PR_ADDED_USER,PR_IMAGE)
                        values(@pr_name,@pr_description,@pr_price,@brand,@category,@pr_cost,@pr_qty,@pr_added_date,@pr_added_user,@pr_image);
                        ";
            migrationBuilder.Sql(sql);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
