using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bumble_bee_API_2.Migrations
{
    public partial class PDO_UpdateCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sql = @"CREATE PROCEDURE UpdateCategory
                        @cat_id int,
                        @cat_name nvarchar(20)
                        as
                        declare @loc_status nvarchar(25)
                        begin try
	                        update Tbl_Categories set CAT_NAME = @cat_name where CAT_ID = @cat_id;
	                        set @loc_status = 'UPDATE SUCCESSFUL'
                        end try
                        begin catch
	                        set @loc_status = 'DATABASE ERROR'
	                        select @loc_status as 'STATUS_MSG'
                        end catch
                        select @loc_status as 'STATUS_MSG'";
            migrationBuilder.Sql(sql);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
