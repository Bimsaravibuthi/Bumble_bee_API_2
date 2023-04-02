using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bumble_bee_API_2.Migrations
{
    public partial class PDO_GetBrand : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sql = @"CREATE PROCEDURE GetBrand
                        @br_id int
                        as
                        if @br_id is null
                        begin
	                        select * from Tbl_Brands;
                        end
                        else
                        begin
	                        select * from Tbl_Brands where BR_ID = @br_id;
                        end";
            migrationBuilder.Sql(sql);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
