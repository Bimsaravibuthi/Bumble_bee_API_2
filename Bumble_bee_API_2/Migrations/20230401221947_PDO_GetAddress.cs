using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bumble_bee_API_2.Migrations
{
    public partial class PDO_GetAddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sql = @"create procedure GetAddress
						@usr_id int,
						@add_id int
						as
						if @usr_id is null AND @add_id is null
						begin
							select ADD_ID,ADD_MOBILE,ADD_NAME,ADD_LINE1,ADD_LINE2,CT_ID,USR_ID
							from tbl_Addresses;
						end
						else
						begin
							if @usr_id is null
							begin
								select ADD_ID,ADD_MOBILE,ADD_NAME,ADD_LINE1,ADD_LINE2,CT_ID,USR_ID
								from tbl_Addresses
								where ADD_ID = @add_id;
							end
							if @add_id is null
							begin
								select ADD_ID,ADD_MOBILE,ADD_NAME,ADD_LINE1,ADD_LINE2,CT_ID,USR_ID
								from tbl_Addresses
								where USR_ID = @usr_id;
							end
						end
						";
			migrationBuilder.Sql(sql);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
