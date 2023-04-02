using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bumble_bee_API_2.Migrations
{
    public partial class UpdateProduct_attribute_name_changed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_UpdateProducts_Tbl_Products_PRO_ID",
                table: "Tbl_UpdateProducts");

            migrationBuilder.RenameColumn(
                name: "PRO_ID",
                table: "Tbl_UpdateProducts",
                newName: "PR_ID");

            migrationBuilder.RenameIndex(
                name: "IX_Tbl_UpdateProducts_PRO_ID",
                table: "Tbl_UpdateProducts",
                newName: "IX_Tbl_UpdateProducts_PR_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_UpdateProducts_Tbl_Products_PR_ID",
                table: "Tbl_UpdateProducts",
                column: "PR_ID",
                principalTable: "Tbl_Products",
                principalColumn: "PR_ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_UpdateProducts_Tbl_Products_PR_ID",
                table: "Tbl_UpdateProducts");

            migrationBuilder.RenameColumn(
                name: "PR_ID",
                table: "Tbl_UpdateProducts",
                newName: "PRO_ID");

            migrationBuilder.RenameIndex(
                name: "IX_Tbl_UpdateProducts_PR_ID",
                table: "Tbl_UpdateProducts",
                newName: "IX_Tbl_UpdateProducts_PRO_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_UpdateProducts_Tbl_Products_PRO_ID",
                table: "Tbl_UpdateProducts",
                column: "PRO_ID",
                principalTable: "Tbl_Products",
                principalColumn: "PR_ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
