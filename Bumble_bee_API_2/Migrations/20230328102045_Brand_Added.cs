using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bumble_bee_API_2.Migrations
{
    public partial class Brand_Added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BRANDBR_ID",
                table: "tbl_Product",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "tbl_Brands",
                columns: table => new
                {
                    BR_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BR_NAME = table.Column<string>(type: "nvarchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Brands", x => x.BR_ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Product_BRANDBR_ID",
                table: "tbl_Product",
                column: "BRANDBR_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Product_tbl_Brands_BRANDBR_ID",
                table: "tbl_Product",
                column: "BRANDBR_ID",
                principalTable: "tbl_Brands",
                principalColumn: "BR_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Product_tbl_Brands_BRANDBR_ID",
                table: "tbl_Product");

            migrationBuilder.DropTable(
                name: "tbl_Brands");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Product_BRANDBR_ID",
                table: "tbl_Product");

            migrationBuilder.DropColumn(
                name: "BRANDBR_ID",
                table: "tbl_Product");
        }
    }
}
