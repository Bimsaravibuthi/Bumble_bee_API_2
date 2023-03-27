using Microsoft.EntityFrameworkCore;

namespace Bumble_bee_API_2.DAL
{
    public class DatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Bumble_bee_2;Integrated Security=True";
            optionsBuilder.UseSqlServer(connectionString);
        }
        public DbSet<tbl_User>? tbl_Users { get; set; }
        public DbSet<tbl_Address>? tbl_Addresses { get; set; }
        public DbSet<tbl_City>? tbl_Cities { get; set; }
        public DbSet<tbl_District>? tbl_Districts { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Ignore<>();
        }
    }
}
