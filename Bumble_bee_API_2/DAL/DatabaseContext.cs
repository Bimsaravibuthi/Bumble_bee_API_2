using Microsoft.EntityFrameworkCore;

namespace Bumble_bee_API_2.DAL
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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Ignore<>();
            modelBuilder.Entity<tbl_UserProduct>()
            .HasKey(ba => new { ba.USER_ID, ba.PRODUCT_ID });

            modelBuilder.Entity<tbl_UserProduct>()
                .HasOne(ba => ba.tbl_Product)
                .WithMany(b => b.tbl_UserProducts)
                .HasForeignKey(ba => ba.PRODUCT_ID);

            modelBuilder.Entity<tbl_UserProduct>()
                .HasOne(ba => ba.tbl_User)
                .WithMany(a => a.tbl_UserProducts)
                .HasForeignKey(ba => ba.USER_ID);
        }
    }
}
