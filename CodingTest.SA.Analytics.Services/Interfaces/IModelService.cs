using CodingTest.SA.Analytics.Services.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CodingTest.SA.Analytics.Services.Interfaces
{
    public interface IModelService
    {
        Task<List<ModelDto>> GetAllAsync();
        Task<List<MetricsDto>> GetAllYearlyPnlPriceMetricsAsync();
    }
}
