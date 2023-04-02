using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bumble_bee_API_2.Migrations
{
    public partial class PDO_UpdateBrand : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sql = @"CREATE PROCEDURE UpdateBrand
                        @br_id int,
                        @br_name nvarchar(20)
                        as
                        declare @loc_status nvarchar(25)
                        begin try
	                        update Tbl_Brands set BR_NAME = @br_name where BR_ID = @br_id;
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
