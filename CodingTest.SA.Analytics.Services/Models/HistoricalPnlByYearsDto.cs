using System.Collections.Generic;

namespace CodingTest.SA.Analytics.Services.Models
{
    public class HistoricalPnlByYearsDto
    {
        public int Year { get; set; }
        public decimal CummulativePnl { get; set; }
        public List<ModelResultDto> ModelResults { get; set; }

        public HistoricalPnlByYearsDto()
        {
            ModelResults = new List<ModelResultDto>();
        }
    }
}
