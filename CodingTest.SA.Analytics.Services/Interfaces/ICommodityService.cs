using CodingTest.SA.Analytics.Services.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CodingTest.SA.Analytics.Services.Interfaces
{
    public interface ICommodityService
    {
        Task<List<CommodityDto>> GetAllAsync();
        Task<List<HistoricalCommodityDto>> GetAllPnlYTDMetricAsync();
        Task<HistoricalCommodityDto> GetPnlYTDMetricByIdAsync(int id);
    }
}
