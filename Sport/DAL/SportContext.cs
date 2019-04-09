using System.Data.Entity;
using Sport.Models;

namespace Sport.DAL
{
    public class SportContext : DbContext
    {
        public SportContext() : base("SportContext")
        {

        }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryService> CategoryServices { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Station> Stations { get; set; }
        public DbSet<User> Users { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<SportContext>(null);
            base.OnModelCreating(modelBuilder);
        }
    }
}