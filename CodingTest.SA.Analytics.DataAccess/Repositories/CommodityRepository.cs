using CodingTest.SA.Analytics.DataAccess.Contexts.Interfaces;
using CodingTest.SA.Analytics.DataAccess.Models;
using CodingTest.SA.Analytics.DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTest.SA.Analytics.DataAccess.Repositories
{
    public class CommodityRepository : Repository<Commodity>, ICommodityRepository
    {
        private readonly IAnalyticsDbContext _context;
        public CommodityRepository(IAnalyticsDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
