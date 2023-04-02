using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bumble_bee_API_2.Migrations
{
    public partial class UpdateProduct_attribute_added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Tbl_UpdateProducts",
                table: "Tbl_UpdateProducts");

            migrationBuilder.AddColumn<int>(
                name: "UPDATE_ID",
                table: "Tbl_UpdateProducts",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tbl_UpdateProducts",
                table: "Tbl_UpdateProducts",
                column: "UPDATE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_UpdateProducts_USR_ID",
                table: "Tbl_UpdateProducts",
                column: "USR_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Tbl_UpdateProducts",
                table: "Tbl_UpdateProducts");

            migrationBuilder.DropIndex(
                name: "IX_Tbl_UpdateProducts_USR_ID",
                table: "Tbl_UpdateProducts");

            migrationBuilder.DropColumn(
                name: "UPDATE_ID",
                table: "Tbl_UpdateProducts");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tbl_UpdateProducts",
                table: "Tbl_UpdateProducts",
                columns: new[] { "USR_ID", "PR_ID" });
        }
    }
}
