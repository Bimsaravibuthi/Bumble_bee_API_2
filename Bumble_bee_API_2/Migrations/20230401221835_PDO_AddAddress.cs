using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bumble_bee_API_2.Migrations
{
    public partial class PDO_AddAddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sql = @"create procedure AddAddress
                        @add_name nvarchar(20),
                        @add_mobile nvarchar(10),
                        @add_line1 nvarchar(50),
                        @add_line2 nvarchar(50),
                        @ct_id int,
                        @usr_id int
                        as
                        declare @loc_status nvarchar(25)

                        begin try
	                        insert into tbl_Addresses(ADD_NAME,ADD_MOBILE,ADD_LINE1,ADD_LINE2,CT_ID,USR_ID)
	                        values(@add_name,@add_mobile,@add_line1,@add_line2,@ct_id,@usr_id);
	                        set @loc_status = 'INSERT SUCCESSFUL'
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
