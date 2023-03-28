using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bumble_bee_API_2.Migrations
{
    public partial class Category_Added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CATEGORYCAT_ID",
                table: "tbl_Product",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "tbl_Category",
                columns: table => new
                {
                    CAT_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CAT_NAME = table.Column<string>(type: "nvarchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Category", x => x.CAT_ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Product_CATEGORYCAT_ID",
                table: "tbl_Product",
                column: "CATEGORYCAT_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Product_tbl_Category_CATEGORYCAT_ID",
                table: "tbl_Product",
                column: "CATEGORYCAT_ID",
                principalTable: "tbl_Category",
                principalColumn: "CAT_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Product_tbl_Category_CATEGORYCAT_ID",
                table: "tbl_Product");

            migrationBuilder.DropTable(
                name: "tbl_Category");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Product_CATEGORYCAT_ID",
                table: "tbl_Product");

            migrationBuilder.DropColumn(
                name: "CATEGORYCAT_ID",
                table: "tbl_Product");
        }
    }
}
