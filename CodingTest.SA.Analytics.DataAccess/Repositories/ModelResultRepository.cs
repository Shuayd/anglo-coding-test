using CodingTest.SA.Analytics.DataAccess.Contexts.Interfaces;
using CodingTest.SA.Analytics.DataAccess.Models;
using CodingTest.SA.Analytics.DataAccess.Repositories.Interfaces;

namespace CodingTest.SA.Analytics.DataAccess.Repositories
{
    public class ModelResultRepository : Repository<ModelResult>, IModelResultRepository
    {
        private readonly IAnalyticsDbContext _context;
        public ModelResultRepository(IAnalyticsDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
