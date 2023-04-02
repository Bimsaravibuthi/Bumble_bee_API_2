using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bumble_bee_API_2.Migrations
{
    public partial class PDO_UpdateProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sql = @"create procedure UpdateProduct
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
						declare @loc_status nvarchar(25)

						begin try
							begin transaction;

							update Tbl_Products set PR_NAME = @pr_name,PR_DESCRIPTION = @pr_description,PR_PRICE = @pr_price,
							PR_COST = @pr_cost,PR_QTY = @pr_qty,PR_IMAGE = @pr_image,BR_ID = @brand,CAT_ID = @category;

							insert into Tbl_UpdateProducts(USR_ID,PR_ID,UPDATE_DATE,UPDATE_DESC)
							values(@update_user,@pr_id,@update_date,@update_desc);

							commit transaction;

							set @loc_status = 'UPDATE SUCCESSFUL'
						end try
						begin catch
							set @loc_status = 'DATABASE_ERROR'
							select @loc_status as 'STATUS_MSG';
							rollback transaction;
						end catch
						select @loc_status as 'STATUS_MSG';";
			migrationBuilder.Sql(sql);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
