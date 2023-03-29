using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bumble_bee_API_2.Migrations
{
    public partial class Product_and_UserProduct_updated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_UserProduct_tbl_Users_USER_ID",
                table: "tbl_UserProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_UserProduct",
                table: "tbl_UserProduct");

            migrationBuilder.DropColumn(
                name: "USER_ID",
                table: "tbl_UserProduct");

            migrationBuilder.DropColumn(
                name: "ADDED_USER",
                table: "tbl_UserProduct");

            migrationBuilder.RenameColumn(
                name: "LAST_UP_USER",
                table: "tbl_UserProduct",
                newName: "UPDATE_USER");

            migrationBuilder.AddColumn<DateTime>(
                name: "UPDATE_DATE",
                table: "tbl_UserProduct",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UPDATE_DESC",
                table: "tbl_UserProduct",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "ADDED_DATE",
                table: "tbl_Product",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "ADDED_USER",
                table: "tbl_Product",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_UserProduct",
                table: "tbl_UserProduct",
                columns: new[] { "UPDATE_USER", "PRODUCT_ID" });

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_UserProduct_tbl_Users_UPDATE_USER",
                table: "tbl_UserProduct",
                column: "UPDATE_USER",
                principalTable: "tbl_Users",
                principalColumn: "USR_ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_UserProduct_tbl_Users_UPDATE_USER",
                table: "tbl_UserProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_UserProduct",
                table: "tbl_UserProduct");

            migrationBuilder.DropColumn(
                name: "UPDATE_DATE",
                table: "tbl_UserProduct");

            migrationBuilder.DropColumn(
                name: "UPDATE_DESC",
                table: "tbl_UserProduct");

            migrationBuilder.DropColumn(
                name: "ADDED_DATE",
                table: "tbl_Product");

            migrationBuilder.DropColumn(
                name: "ADDED_USER",
                table: "tbl_Product");

            migrationBuilder.RenameColumn(
                name: "UPDATE_USER",
                table: "tbl_UserProduct",
                newName: "LAST_UP_USER");

            migrationBuilder.AddColumn<int>(
                name: "USER_ID",
                table: "tbl_UserProduct",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ADDED_USER",
                table: "tbl_UserProduct",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_UserProduct",
                table: "tbl_UserProduct",
                columns: new[] { "USER_ID", "PRODUCT_ID" });

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_UserProduct_tbl_Users_USER_ID",
                table: "tbl_UserProduct",
                column: "USER_ID",
                principalTable: "tbl_Users",
                principalColumn: "USR_ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
