using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bumble_bee_API_2.Migrations
{
    public partial class UpdateProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tbl_UpdateProducts",
                columns: table => new
                {
                    USR_ID = table.Column<int>(type: "int", nullable: false),
                    PRO_ID = table.Column<int>(type: "int", nullable: false),
                    UPDATE_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UPDATE_DESC = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_UpdateProducts", x => new { x.USR_ID, x.PRO_ID });
                    table.ForeignKey(
                        name: "FK_Tbl_UpdateProducts_Tbl_Products_PRO_ID",
                        column: x => x.PRO_ID,
                        principalTable: "Tbl_Products",
                        principalColumn: "PR_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tbl_UpdateProducts_Tbl_Users_USR_ID",
                        column: x => x.USR_ID,
                        principalTable: "Tbl_Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_UpdateProducts_PRO_ID",
                table: "Tbl_UpdateProducts",
                column: "PRO_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tbl_UpdateProducts");
        }
    }
}
