using CodingTest.SA.Analytics.DataAccess.Contexts.Interfaces;
using CodingTest.SA.Analytics.DataAccess.Models;
using CodingTest.SA.Analytics.DataAccess.Repositories.Interfaces;

namespace CodingTest.SA.Analytics.DataAccess.Repositories
{
    public class ModelRespository : Repository<Model>, IModelRepository
    {
        private readonly IAnalyticsDbContext _context;
        public ModelRespository(IAnalyticsDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
