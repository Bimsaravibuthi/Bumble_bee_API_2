using Microsoft.EntityFrameworkCore;

namespace Bumble_bee_API_2.Database
{
    public class DatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Bumble_bee;Integrated Security=True";
            optionsBuilder.UseSqlServer(connectionString);
        }
        public DbSet<tbl_User>? Tbl_Users { get; set; }
        public DbSet<tbl_Address>? Tbl_Addresses { get; set; }
        public DbSet<tbl_City>? Tbl_Cities { get; set; }
        public DbSet<tbl_District>? Tbl_Districts { get; set; }
        public DbSet<tbl_Brand>? Tbl_Brands { get; set;}
        public DbSet<tbl_Category>? Tbl_Categories { get; set; }
        public DbSet<tbl_Product>? Tbl_Products { get; set; }
        public DbSet<tbl_UpdateProduct>? Tbl_UpdateProducts { get; set;}

        [Keyless]
        public class StatusCode
        {
            public int STATUS_CODE { get; set; }
            public string? STATUS_MSG { get; set; }
        }
        [Keyless]
        public class Login
        {
            public int USR_ID { get; set; }
            public string? USR_EMAIL { get; set; }
            public string? USR_PWD { get; set; }
            public string? USR_FNAME { get; set; }
            public string? USR_LNAME { get; set; }
        }
        public DbSet<StatusCode>? statusCodes { get; set; }
        public DbSet<Login>? Logins { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Ignore<StatusCode>();
            //modelBuilder.Ignore<Login>();
        }
    }
}