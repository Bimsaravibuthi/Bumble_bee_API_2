using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bumble_bee_API_2.Migrations
{
    public partial class User_attribute_names_changed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CUS_STATUS",
                table: "tbl_Users",
                newName: "USR_STATUS");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "USR_STATUS",
                table: "tbl_Users",
                newName: "CUS_STATUS");
        }
    }
}
