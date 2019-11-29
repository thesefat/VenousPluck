using System.Data.Entity;
using VenousPluck.Models.BaseModels;

namespace VenousPluck.Persistance.Db
{
    public class ProjectDbContext : DbContext
    {

        public ProjectDbContext() : base("ProjectDbContext") { }

        public DbSet<User> Users { get; set; }
        public DbSet<Donor> Donors { get; set; }
    }
}
