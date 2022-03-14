using CodingTest.SA.Analytics.DataAccess.Contexts.Interfaces;
using CodingTest.SA.Analytics.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace CodingTest.SA.Analytics.DataAccess.Contexts
{
    public class AnalyticsDbContext : DbContext, IAnalyticsDbContext
    {
        public AnalyticsDbContext()
        {
        }

        public AnalyticsDbContext(DbContextOptions<AnalyticsDbContext> options) : base(options)
        {

        }

        public DbSet<Model> Model { get; set; }
        public DbSet<ModelResult> ModelResult { get; set; }
        public DbSet<Commodity> Commodity { get; set; }
        public DbSet<Contract> Contract { get; set; }
        public DbSet<NewTradeAction> NewTradeAction { get; set; }
        public DbSet<Position> Position { get; set; }
    }
}
