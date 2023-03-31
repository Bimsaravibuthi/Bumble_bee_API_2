using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bumble_bee_API_2.Migrations
{
    public partial class PDO_GetUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sql = @"CREATE PROCEDURE GetUser
                        @usr_id int
                        as
                        if @usr_id is null
	                        begin
		                        select * from tbl_Users;
	                        end
                        else
	                        begin
		                        select * from tbl_Users where USR_ID = @usr_id;
	                        end";
            migrationBuilder.Sql(sql);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
