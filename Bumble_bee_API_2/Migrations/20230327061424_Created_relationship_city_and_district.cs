using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bumble_bee_API_2.Migrations
{
    public partial class Created_relationship_city_and_district : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DISTRICTDT_ID",
                table: "tbl_Cities",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Cities_DISTRICTDT_ID",
                table: "tbl_Cities",
                column: "DISTRICTDT_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Cities_tbl_Districts_DISTRICTDT_ID",
                table: "tbl_Cities",
                column: "DISTRICTDT_ID",
                principalTable: "tbl_Districts",
                principalColumn: "DT_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Cities_tbl_Districts_DISTRICTDT_ID",
                table: "tbl_Cities");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Cities_DISTRICTDT_ID",
                table: "tbl_Cities");

            migrationBuilder.DropColumn(
                name: "DISTRICTDT_ID",
                table: "tbl_Cities");
        }
    }
}
