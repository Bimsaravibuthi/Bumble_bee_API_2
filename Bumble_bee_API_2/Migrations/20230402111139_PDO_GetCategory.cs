using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bumble_bee_API_2.Migrations
{
    public partial class PDO_GetCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sql = @"CREATE PROCEDURE GetCategory
                        @cat_id int
                        as
                        if @cat_id is null
                        begin
	                        select * from Tbl_Categories;
                        end
                        else
                        begin
	                        select * from Tbl_Categories where CAT_ID = @cat_id;
                        end";
            migrationBuilder.Sql(sql);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
