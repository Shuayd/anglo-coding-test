using System.Collections.Generic;

namespace CodingTest.SA.Analytics.Services.Models
{
    public class HistoricalCommodityDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<HistoricalPnlByYearsDto> Metrics { get; set; }

        public HistoricalCommodityDto()
        {
            Metrics = new List<HistoricalPnlByYearsDto>();
        }
    }
}
