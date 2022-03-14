using System.Collections.Generic;

namespace CodingTest.SA.Analytics.Services.Models
{
    public class MetricsDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<PriceYTDDto> Prices { get; set; }

        public MetricsDto()
        {
            Prices = new List<PriceYTDDto>();
        }
    }
}
