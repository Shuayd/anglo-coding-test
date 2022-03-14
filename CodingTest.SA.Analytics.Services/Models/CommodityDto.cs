using System.Collections.Generic;

namespace CodingTest.SA.Analytics.Services.Models
{
    public class CommodityDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ModelResultDto> ModelResult { get; set; }
    }
}
