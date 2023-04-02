using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bumble_bee_API_2.Migrations
{
    public partial class PDO_AddProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sql = @"create procedure AddProduct
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
                        declare @loc_status nvarchar(25)

                        begin try
	                        insert into tbl_Products(PR_NAME,PR_DESCRIPTION,PR_PRICE,BR_ID,CAT_ID,PR_COST,PR_QTY,PR_ADDED_DATE,PR_ADDED_USER,PR_IMAGE)
	                        values(@pr_name,@pr_description,@pr_price,@brand,@category,@pr_cost,@pr_qty,@pr_added_date,@pr_added_user,@pr_image);
	                        set @loc_status = 'INSERT SUCCESSFUL'
                        end try
                        begin catch
	                        set @loc_status = 'DATABASE_ERROR'
	                        SELECT @loc_status AS 'STATUS_MSG';
                        end catch
                        SELECT @loc_status AS 'STATUS_MSG';";
            migrationBuilder.Sql(sql);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
