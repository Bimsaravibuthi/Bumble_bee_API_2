using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bumble_bee_API_2.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_Product",
                columns: table => new
                {
                    PR_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PR_NAME = table.Column<string>(type: "nvarchar(25)", nullable: false),
                    PR_DESCRIPTION = table.Column<string>(type: "nvarchar(MAX)", nullable: false),
                    PR_PRICE = table.Column<string>(type: "nvarchar(7)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Product", x => x.PR_ID);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Producttbl_User",
                columns: table => new
                {
                    PRODUCTPR_ID = table.Column<int>(type: "int", nullable: false),
                    USERSUSR_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Producttbl_User", x => new { x.PRODUCTPR_ID, x.USERSUSR_ID });
                    table.ForeignKey(
                        name: "FK_tbl_Producttbl_User_tbl_Product_PRODUCTPR_ID",
                        column: x => x.PRODUCTPR_ID,
                        principalTable: "tbl_Product",
                        principalColumn: "PR_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_Producttbl_User_tbl_Users_USERSUSR_ID",
                        column: x => x.USERSUSR_ID,
                        principalTable: "tbl_Users",
                        principalColumn: "USR_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Producttbl_User_USERSUSR_ID",
                table: "tbl_Producttbl_User",
                column: "USERSUSR_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_Producttbl_User");

            migrationBuilder.DropTable(
                name: "tbl_Product");
        }
    }
}
