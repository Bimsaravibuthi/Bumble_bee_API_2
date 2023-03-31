using Microsoft.EntityFrameworkCore;

namespace Bumble_bee_API_2.Database
{
    public class DatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Bumble_bee_3;Integrated Security=True";
            optionsBuilder.UseSqlServer(connectionString);
        }
        public DbSet<tbl_User>? tbl_Users { get; set; }
        public DbSet<tbl_Address>? tbl_Addresses { get; set; }
        public DbSet<tbl_City>? tbl_Cities { get; set; }
        public DbSet<tbl_District>? tbl_Districts { get; set; }
        public DbSet<tbl_Brand>? tbl_Brands { get; set; }
        public DbSet<tbl_Category>? tbl_Categories { get; set; }
        public DbSet<tbl_Product>? tbl_Products { get; set; }
        public DbSet<tbl_UserProduct>? tbl_UserProducts { get; set; }

        [Keyless]
        public class StatusCode
        {
            public string? STATUS_CODE { get; set; }
        }
        public DbSet<StatusCode>? statusCodes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Ignore<>();
            modelBuilder.Entity<tbl_UserProduct>()
            .HasKey(ba => new { ba.UPDATE_USER, ba.PRODUCT_ID });

            modelBuilder.Entity<tbl_UserProduct>()
                .HasOne(ba => ba.tbl_Product)
                .WithMany(b => b.tbl_UserProducts)
                .HasForeignKey(ba => ba.PRODUCT_ID);

            modelBuilder.Entity<tbl_UserProduct>()
                .HasOne(ba => ba.tbl_User)
                .WithMany(a => a.tbl_UserProducts)
                .HasForeignKey(ba => ba.UPDATE_USER);
        }
    }
}
