using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bumble_bee_API_2.Migrations
{
    public partial class Pre_test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_UserProduct");

            migrationBuilder.DropTable(
                name: "tbl_Product");

            migrationBuilder.DropTable(
                name: "tbl_Category");

            migrationBuilder.CreateTable(
                name: "tbl_Categories",
                columns: table => new
                {
                    CAT_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CAT_NAME = table.Column<string>(type: "nvarchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Categories", x => x.CAT_ID);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Products",
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
                    BRANDBR_ID = table.Column<int>(type: "int", nullable: true),
                    CATEGORYCAT_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Products", x => x.PR_ID);
                    table.ForeignKey(
                        name: "FK_tbl_Products_tbl_Brands_BRANDBR_ID",
                        column: x => x.BRANDBR_ID,
                        principalTable: "tbl_Brands",
                        principalColumn: "BR_ID");
                    table.ForeignKey(
                        name: "FK_tbl_Products_tbl_Categories_CATEGORYCAT_ID",
                        column: x => x.CATEGORYCAT_ID,
                        principalTable: "tbl_Categories",
                        principalColumn: "CAT_ID");
                });

            migrationBuilder.CreateTable(
                name: "tbl_UserProducts",
                columns: table => new
                {
                    UPDATE_USER = table.Column<int>(type: "int", nullable: false),
                    PRODUCT_ID = table.Column<int>(type: "int", nullable: false),
                    UPDATE_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UPDATE_DESC = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_UserProducts", x => new { x.UPDATE_USER, x.PRODUCT_ID });
                    table.ForeignKey(
                        name: "FK_tbl_UserProducts_tbl_Products_PRODUCT_ID",
                        column: x => x.PRODUCT_ID,
                        principalTable: "tbl_Products",
                        principalColumn: "PR_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_UserProducts_tbl_Users_UPDATE_USER",
                        column: x => x.UPDATE_USER,
                        principalTable: "tbl_Users",
                        principalColumn: "USR_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Products_BRANDBR_ID",
                table: "tbl_Products",
                column: "BRANDBR_ID");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Products_CATEGORYCAT_ID",
                table: "tbl_Products",
                column: "CATEGORYCAT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_UserProducts_PRODUCT_ID",
                table: "tbl_UserProducts",
                column: "PRODUCT_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_UserProducts");

            migrationBuilder.DropTable(
                name: "tbl_Products");

            migrationBuilder.DropTable(
                name: "tbl_Categories");

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

            migrationBuilder.CreateTable(
                name: "tbl_Product",
                columns: table => new
                {
                    PR_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BRANDBR_ID = table.Column<int>(type: "int", nullable: true),
                    CATEGORYCAT_ID = table.Column<int>(type: "int", nullable: true),
                    PR_ADDED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PR_ADDED_USER = table.Column<int>(type: "int", nullable: false),
                    PR_COST = table.Column<string>(type: "nvarchar(7)", nullable: false),
                    PR_DESCRIPTION = table.Column<string>(type: "nvarchar(MAX)", nullable: false),
                    PR_IMAGE = table.Column<byte[]>(type: "varbinary(MAX)", nullable: true),
                    PR_NAME = table.Column<string>(type: "nvarchar(25)", nullable: false),
                    PR_PRICE = table.Column<string>(type: "nvarchar(7)", nullable: false),
                    PR_QTY = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Product", x => x.PR_ID);
                    table.ForeignKey(
                        name: "FK_tbl_Product_tbl_Brands_BRANDBR_ID",
                        column: x => x.BRANDBR_ID,
                        principalTable: "tbl_Brands",
                        principalColumn: "BR_ID");
                    table.ForeignKey(
                        name: "FK_tbl_Product_tbl_Category_CATEGORYCAT_ID",
                        column: x => x.CATEGORYCAT_ID,
                        principalTable: "tbl_Category",
                        principalColumn: "CAT_ID");
                });

            migrationBuilder.CreateTable(
                name: "tbl_UserProduct",
                columns: table => new
                {
                    UPDATE_USER = table.Column<int>(type: "int", nullable: false),
                    PRODUCT_ID = table.Column<int>(type: "int", nullable: false),
                    UPDATE_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UPDATE_DESC = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_UserProduct", x => new { x.UPDATE_USER, x.PRODUCT_ID });
                    table.ForeignKey(
                        name: "FK_tbl_UserProduct_tbl_Product_PRODUCT_ID",
                        column: x => x.PRODUCT_ID,
                        principalTable: "tbl_Product",
                        principalColumn: "PR_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_UserProduct_tbl_Users_UPDATE_USER",
                        column: x => x.UPDATE_USER,
                        principalTable: "tbl_Users",
                        principalColumn: "USR_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Product_BRANDBR_ID",
                table: "tbl_Product",
                column: "BRANDBR_ID");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Product_CATEGORYCAT_ID",
                table: "tbl_Product",
                column: "CATEGORYCAT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_UserProduct_PRODUCT_ID",
                table: "tbl_UserProduct",
                column: "PRODUCT_ID");
        }
    }
}
