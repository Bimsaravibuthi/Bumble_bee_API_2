using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bumble_bee_API_2.Migrations
{
    public partial class PDO_AddUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sql = @"CREATE PROCEDURE AddUser
                        @usr_type nvarchar(2),
                        @usr_nic nvarchar(12),
                        @usr_fname nvarchar(20),
                        @usr_lname nvarchar(20),
                        @usr_email nvarchar(25),
                        @usr_pwd varbinary(MAX),
                        @usr_status bit
                        as
                        declare @loc_email nvarchar(25)
                        declare @loc_status nvarchar(25)

                        set @loc_email  = (select USR_EMAIL from tbl_Users where USR_EMAIL = @usr_email)

                        if @loc_email is null
	                        begin
		                        insert into tbl_Users(USR_TYPE,USR_NIC,USR_FNAME,USR_LNAME,USR_EMAIL,USR_PWD,USR_STATUS)
		                        values(@usr_type,@usr_nic,@usr_fname,@usr_lname,@usr_email,@usr_pwd,@usr_status);
		                        set @loc_status = 'DONE'
	                        end
                        else
	                        begin
		                        set @loc_status = 'EMAIL_EXIST'
	                        end
                        select @loc_status as 'STATUS_CODE';";
            migrationBuilder.Sql(sql);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
