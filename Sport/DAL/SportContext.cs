using System.Data.Entity;
using Sport.Models;

namespace Sport.DAL
{
    public class SportContext:DbContext
    {
        public SportContext() : base("SportContext")
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Station> Stations { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}