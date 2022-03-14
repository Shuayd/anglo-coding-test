using System;

namespace CodingTest.SA.Analytics.Services.Models
{
    public class PriceYTDDto
    {
        public int Year { get; set; }
        public decimal CummulativePrice { get; set; }
        public decimal CummulativePnl { get; set; }
    }
}
