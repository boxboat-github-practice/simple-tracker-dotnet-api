using SimpleTracker.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace SimpleTracker.Api.Data
{
    public class SimpleTrackerContext : DbContext
    {
        public SimpleTrackerContext(DbContextOptions<SimpleTrackerContext> options) : base(options)
        {
        }

        public DbSet<Employee> employees { get; set; }
        public DbSet<ModelClient> clients { get; set; }
        public DbSet<Contract> contracts { get; set; }
        public DbSet<History> histories { get; set; }
    }
}