using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bumble_bee_API_2.Migrations
{
    public partial class Initial_Database : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_Cities",
                columns: table => new
                {
                    CT_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CT_NAME = table.Column<string>(type: "nvarchar(25)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Cities", x => x.CT_ID);
                });

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
                    DISTRICTDT_ID = table.Column<int>(type: "int", nullable: false),
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
                        name: "FK_tbl_Addresses_tbl_Districts_DISTRICTDT_ID",
                        column: x => x.DISTRICTDT_ID,
                        principalTable: "tbl_Districts",
                        principalColumn: "DT_ID",
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
                name: "IX_tbl_Addresses_DISTRICTDT_ID",
                table: "tbl_Addresses",
                column: "DISTRICTDT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Addresses_USERUSR_ID",
                table: "tbl_Addresses",
                column: "USERUSR_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_Addresses");

            migrationBuilder.DropTable(
                name: "tbl_Cities");

            migrationBuilder.DropTable(
                name: "tbl_Districts");

            migrationBuilder.DropTable(
                name: "tbl_Users");
        }
    }
}
