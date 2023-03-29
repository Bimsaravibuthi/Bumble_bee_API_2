using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bumble_bee_API_2.Migrations
{
    public partial class Product_attribute_names_changed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ADDED_USER",
                table: "tbl_Product",
                newName: "PR_ADDED_USER");

            migrationBuilder.RenameColumn(
                name: "ADDED_DATE",
                table: "tbl_Product",
                newName: "PR_ADDED_DATE");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PR_ADDED_USER",
                table: "tbl_Product",
                newName: "ADDED_USER");

            migrationBuilder.RenameColumn(
                name: "PR_ADDED_DATE",
                table: "tbl_Product",
                newName: "ADDED_DATE");
        }
    }
}
