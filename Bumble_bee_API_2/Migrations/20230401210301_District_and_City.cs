using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bumble_bee_API_2.Migrations
{
    public partial class District_and_City : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CT_ID",
                table: "Tbl_Addresses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Tbl_Districts",
                columns: table => new
                {
                    DT_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DT_NAME = table.Column<string>(type: "nvarchar(15)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Districts", x => x.DT_ID);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Cities",
                columns: table => new
                {
                    CT_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CT_NAME = table.Column<string>(type: "nvarchar(25)", nullable: false),
                    DT_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Cities", x => x.CT_ID);
                    table.ForeignKey(
                        name: "FK_Tbl_Cities_Tbl_Districts_DT_ID",
                        column: x => x.DT_ID,
                        principalTable: "Tbl_Districts",
                        principalColumn: "DT_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Addresses_CT_ID",
                table: "Tbl_Addresses",
                column: "CT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Cities_DT_ID",
                table: "Tbl_Cities",
                column: "DT_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_Addresses_Tbl_Cities_CT_ID",
                table: "Tbl_Addresses",
                column: "CT_ID",
                principalTable: "Tbl_Cities",
                principalColumn: "CT_ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Addresses_Tbl_Cities_CT_ID",
                table: "Tbl_Addresses");

            migrationBuilder.DropTable(
                name: "Tbl_Cities");

            migrationBuilder.DropTable(
                name: "Tbl_Districts");

            migrationBuilder.DropIndex(
                name: "IX_Tbl_Addresses_CT_ID",
                table: "Tbl_Addresses");

            migrationBuilder.DropColumn(
                name: "CT_ID",
                table: "Tbl_Addresses");
        }
    }
}
