using CodingTest.SA.Analytics.DataAccess.Contexts.Interfaces;
using CodingTest.SA.Analytics.DataAccess.Models;
using CodingTest.SA.Analytics.DataAccess.Repositories.Interfaces;

namespace CodingTest.SA.Analytics.DataAccess.Repositories
{
    public class NewTradeActionRepository : Repository<NewTradeAction>, INewTradeActionRepository
    {
        private readonly IAnalyticsDbContext _context;
        public NewTradeActionRepository(IAnalyticsDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
