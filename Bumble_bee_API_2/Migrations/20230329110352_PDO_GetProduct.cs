using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bumble_bee_API_2.Migrations
{
    public partial class PDO_GetProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sql = @"CREATE PROCEDURE GetProduct
                        @pr_id int
                        as
                        if @pr_id is null
	                        begin
		                        select * from tbl_Product;
	                        end
                        else
	                        begin
		                        select * from tbl_Product where PR_ID = @pr_id;
	                        end";
            migrationBuilder.Sql(sql);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
