using CodingTest.SA.Analytics.Services.Models;
using System.Collections.Generic;

namespace CodingTest.SA.Analytics.Services
{
    public class ModelDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<ModelResultDto> ModelResult { get; set; }
    }
}
