using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bumble_bee_API_2.Migrations
{
    public partial class Brand_and_Category_and_Product : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tbl_Brands",
                columns: table => new
                {
                    BR_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BR_NAME = table.Column<string>(type: "nvarchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Brands", x => x.BR_ID);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Categories",
                columns: table => new
                {
                    CAT_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CAT_NAME = table.Column<string>(type: "nvarchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Categories", x => x.CAT_ID);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Products",
                columns: table => new
                {
                    PR_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PR_NAME = table.Column<string>(type: "nvarchar(25)", nullable: false),
                    PR_DESCRIPTION = table.Column<string>(type: "nvarchar(MAX)", nullable: false),
                    PR_PRICE = table.Column<string>(type: "nvarchar(7)", nullable: false),
                    PR_COST = table.Column<string>(type: "nvarchar(7)", nullable: false),
                    PR_QTY = table.Column<int>(type: "int", nullable: false),
                    PR_ADDED_USER = table.Column<int>(type: "int", nullable: false),
                    PR_ADDED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PR_IMAGE = table.Column<byte[]>(type: "varbinary(MAX)", nullable: true),
                    BR_ID = table.Column<int>(type: "int", nullable: false),
                    CAT_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Products", x => x.PR_ID);
                    table.ForeignKey(
                        name: "FK_Tbl_Products_Tbl_Brands_BR_ID",
                        column: x => x.BR_ID,
                        principalTable: "Tbl_Brands",
                        principalColumn: "BR_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tbl_Products_Tbl_Categories_CAT_ID",
                        column: x => x.CAT_ID,
                        principalTable: "Tbl_Categories",
                        principalColumn: "CAT_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Products_BR_ID",
                table: "Tbl_Products",
                column: "BR_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Products_CAT_ID",
                table: "Tbl_Products",
                column: "CAT_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tbl_Products");

            migrationBuilder.DropTable(
                name: "Tbl_Brands");

            migrationBuilder.DropTable(
                name: "Tbl_Categories");
        }
    }
}
