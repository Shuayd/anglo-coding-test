using CodingTest.SA.Analytics.DataAccess.Contexts.Interfaces;
using CodingTest.SA.Analytics.DataAccess.Models;
using CodingTest.SA.Analytics.DataAccess.Repositories.Interfaces;

namespace CodingTest.SA.Analytics.DataAccess.Repositories
{
    public class PositionRepository : Repository<Position>, IPositionRepository
    {
        private readonly IAnalyticsDbContext _context;
        public PositionRepository(IAnalyticsDbContext context) : base(context)
        {
            _context = context;
        }
    }
}