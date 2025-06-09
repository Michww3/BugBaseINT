using BugBase.DTOs;
using System.Data.Entity;

namespace BugBase.Helpers
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("DbConnection")
        {

        }

        public DbSet<Bug> Bugs { get; set; }
        public DbSet<Employe> Employes { get; set; }

    }
}
