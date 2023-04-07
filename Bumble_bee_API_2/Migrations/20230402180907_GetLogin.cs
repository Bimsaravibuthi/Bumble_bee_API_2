using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bumble_bee_API_2.Migrations
{
    public partial class GetLogin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sql = @"CREATE PROCEDURE GetLogin
                        @email nvarchar(40)
                        as
                        select USR_ID,USR_EMAIL,USR_PWD,USR_FNAME,USR_LNAME from Tbl_Users
                        where USR_EMAIL = @email;";
            migrationBuilder.Sql(sql);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
