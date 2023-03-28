using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bumble_bee_API_2.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_Districts",
                columns: table => new
                {
                    DT_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DT_NAME = table.Column<string>(type: "nvarchar(15)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Districts", x => x.DT_ID);
                });

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
                name: "tbl_Users",
                columns: table => new
                {
                    USR_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    USR_TYPE = table.Column<string>(type: "nvarchar(2)", nullable: false),
                    USR_NIC = table.Column<string>(type: "nvarchar(12)", nullable: false),
                    USR_FNAME = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    USR_LNAME = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    USR_EMAIL = table.Column<string>(type: "nvarchar(25)", nullable: false),
                    USR_PWD = table.Column<byte[]>(type: "varbinary(MAX)", nullable: false),
                    CUS_STATUS = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Users", x => x.USR_ID);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Cities",
                columns: table => new
                {
                    CT_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CT_NAME = table.Column<string>(type: "nvarchar(25)", nullable: false),
                    DISTRICTDT_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Cities", x => x.CT_ID);
                    table.ForeignKey(
                        name: "FK_tbl_Cities_tbl_Districts_DISTRICTDT_ID",
                        column: x => x.DISTRICTDT_ID,
                        principalTable: "tbl_Districts",
                        principalColumn: "DT_ID");
                });

            migrationBuilder.CreateTable(
                name: "tbl_UserProduct",
                columns: table => new
                {
                    USER_ID = table.Column<int>(type: "int", nullable: false),
                    PRODUCT_ID = table.Column<int>(type: "int", nullable: false),
                    ADDED_USER = table.Column<int>(type: "int", nullable: false),
                    LAST_UP_USER = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_UserProduct", x => new { x.USER_ID, x.PRODUCT_ID });
                    table.ForeignKey(
                        name: "FK_tbl_UserProduct_tbl_Product_PRODUCT_ID",
                        column: x => x.PRODUCT_ID,
                        principalTable: "tbl_Product",
                        principalColumn: "PR_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_UserProduct_tbl_Users_USER_ID",
                        column: x => x.USER_ID,
                        principalTable: "tbl_Users",
                        principalColumn: "USR_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Addresses",
                columns: table => new
                {
                    ADD_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ADD_MOBILE = table.Column<int>(type: "int", nullable: false),
                    ADD_NAME = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    ADD_LINE1 = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    ADD_LINE2 = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    CITYCT_ID = table.Column<int>(type: "int", nullable: false),
                    USERUSR_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Addresses", x => x.ADD_ID);
                    table.ForeignKey(
                        name: "FK_tbl_Addresses_tbl_Cities_CITYCT_ID",
                        column: x => x.CITYCT_ID,
                        principalTable: "tbl_Cities",
                        principalColumn: "CT_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_Addresses_tbl_Users_USERUSR_ID",
                        column: x => x.USERUSR_ID,
                        principalTable: "tbl_Users",
                        principalColumn: "USR_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Addresses_CITYCT_ID",
                table: "tbl_Addresses",
                column: "CITYCT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Addresses_USERUSR_ID",
                table: "tbl_Addresses",
                column: "USERUSR_ID");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Cities_DISTRICTDT_ID",
                table: "tbl_Cities",
                column: "DISTRICTDT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_UserProduct_PRODUCT_ID",
                table: "tbl_UserProduct",
                column: "PRODUCT_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_Addresses");

            migrationBuilder.DropTable(
                name: "tbl_UserProduct");

            migrationBuilder.DropTable(
                name: "tbl_Cities");

            migrationBuilder.DropTable(
                name: "tbl_Product");

            migrationBuilder.DropTable(
                name: "tbl_Users");

            migrationBuilder.DropTable(
                name: "tbl_Districts");
        }
    }
}
