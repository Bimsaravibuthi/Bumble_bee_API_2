using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bumble_bee_API_2.Migrations
{
    public partial class PDO_AddUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sql = @"create procedure AddUser
						@usr_type nvarchar(2),
						@usr_nic nvarchar(12),
						@usr_fname nvarchar(20),
						@usr_lname nvarchar(20),
						@usr_email nvarchar(25),
						@usr_pwd varchar(MAX),
						@usr_status bit
						as
						declare @loc_email nvarchar(25)
						declare @loc_status nvarchar(25)

						begin try
							set @loc_email  = (select USR_EMAIL from tbl_Users where USR_EMAIL = @usr_email)

							if @loc_email is null
								begin
									insert into tbl_Users(USR_TYPE,USR_NIC,USR_FNAME,USR_LNAME,USR_EMAIL,USR_PWD,USR_STATUS)
									values(@usr_type,@usr_nic,@usr_fname,@usr_lname,@usr_email,@usr_pwd,@usr_status);
									set @loc_status = 'INSERT SUCCESSFUL'
								end
							else
								begin
									set @loc_status = 'EMAIL_EXIST'
								end
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
