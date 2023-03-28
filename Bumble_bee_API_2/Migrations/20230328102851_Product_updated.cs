using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bumble_bee_API_2.Migrations
{
    public partial class Product_updated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PR_COST",
                table: "tbl_Product",
                type: "nvarchar(7)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "PR_QTY",
                table: "tbl_Product",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PR_COST",
                table: "tbl_Product");

            migrationBuilder.DropColumn(
                name: "PR_QTY",
                table: "tbl_Product");
        }
    }
}
