using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bumble_bee_API_2.Migrations
{
    public partial class User_and_Address : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tbl_Users",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    USR_TYPE = table.Column<string>(type: "nvarchar(2)", nullable: false),
                    USR_NIC = table.Column<string>(type: "nvarchar(12)", nullable: false),
                    USR_FNAME = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    USR_LNAME = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    USR_EMAIL = table.Column<string>(type: "nvarchar(25)", nullable: false),
                    USR_PWD = table.Column<byte[]>(type: "varchar(MAX)", nullable: false),
                    USR_STATUS = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Users", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Addresses",
                columns: table => new
                {
                    ADD_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ADD_MOBILE = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    ADD_NAME = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    ADD_LINE1 = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    ADD_LINE2 = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    USR_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Addresses", x => x.ADD_ID);
                    table.ForeignKey(
                        name: "FK_Tbl_Addresses_Tbl_Users_USR_ID",
                        column: x => x.USR_ID,
                        principalTable: "Tbl_Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Addresses_USR_ID",
                table: "Tbl_Addresses",
                column: "USR_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tbl_Addresses");

            migrationBuilder.DropTable(
                name: "Tbl_Users");
        }
    }
}
