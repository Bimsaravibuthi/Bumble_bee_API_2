using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bumble_bee_API_2.Migrations
{
    public partial class PDO_UpdateAddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sql = @"create procedure UpdateAddress
                        @add_name nvarchar(20),
                        @add_mobile nvarchar(10),
                        @add_line1 nvarchar(50),
                        @add_line2 nvarchar(50),
                        @ct_id int,
                        @add_id int
                        as
                        declare @loc_status nvarchar(25)

                        begin try
	                        update tbl_Addresses set ADD_NAME = @add_name,ADD_MOBILE = @add_mobile,
	                        ADD_LINE1 = @add_line1,ADD_LINE2 = @add_line2,CT_ID = @ct_id
	                        where ADD_ID = @add_id;
	                        set @loc_status = 'UPDATE SUCCESSFUL'
                        end try
                        begin catch
	                        set @loc_status = 'DATABASE_ERROR'
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
