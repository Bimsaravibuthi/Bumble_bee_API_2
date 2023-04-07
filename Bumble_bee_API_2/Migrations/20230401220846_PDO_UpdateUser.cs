using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bumble_bee_API_2.Migrations
{
    public partial class PDO_UpdateUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sql = @"create procedure UpdateUser
                        @usr_type nvarchar(2),
                        @usr_nic nvarchar(12),
                        @usr_fname nvarchar(20),
                        @usr_lname nvarchar(20),
                        @usr_email nvarchar(40),
                        @usr_pwd varchar(MAX),
                        @usr_status bit,
                        @usr_id int
                        as
                        declare @loc_status nvarchar(25)

                        begin try
	                        update tbl_Users set USR_TYPE = @usr_type,USR_NIC = @usr_nic,USR_FNAME = @usr_fname,
	                        USR_LNAME = @usr_lname,USR_EMAIL = @usr_email,USR_PWD = @usr_pwd,USR_STATUS = @usr_status
	                        where USR_ID = @usr_id;
	                        set @loc_status = 'UPDATE SUCCESSFUL'
                        end try
                        begin catch
	                        set @loc_status = 'DATABASE_ERROR'
	                        SELECT @loc_status AS 'STATUS_MSG';
                        end catch
                        SELECT @loc_status AS 'STATUS_MSG';";
            migrationBuilder.Sql(sql);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
