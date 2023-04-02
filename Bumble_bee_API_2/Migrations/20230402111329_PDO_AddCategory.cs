using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bumble_bee_API_2.Migrations
{
    public partial class PDO_AddCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sql = @"CREATE PROCEDURE AddCategory
                        @cat_name nvarchar(20)
                        as
                        declare @loc_status nvarchar(25)
                        begin try
	                        insert into Tbl_Categories(CAT_NAME) values(@cat_name);
	                        set @loc_status = 'INSERT SUCCESSFUL'
                        end try
                        begin catch
	                        set @loc_status = 'DATABASE ERROR'
	                        select @loc_status as 'STATUS_MSG'
                        end catch
                        select @loc_status as 'STATUS_MSG'";
            migrationBuilder.Sql(sql);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
