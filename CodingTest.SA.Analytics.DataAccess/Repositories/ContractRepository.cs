using CodingTest.SA.Analytics.DataAccess.Contexts.Interfaces;
using CodingTest.SA.Analytics.DataAccess.Models;
using CodingTest.SA.Analytics.DataAccess.Repositories.Interfaces;

namespace CodingTest.SA.Analytics.DataAccess.Repositories
{
    public class ContractRepository : Repository<Contract>, IContractRepository
    {
        private readonly IAnalyticsDbContext _context;
        public ContractRepository(IAnalyticsDbContext context) : base(context)
        {
            _context = context;
        }

    }
}
