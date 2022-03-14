using CodingTest.SA.Analytics.WebAPI.Data.Models;
using CsvHelper.Configuration;

namespace CodingTest.SA.Analytics.WebAPI.Mappings.CsvHelper
{
    public class ModelResultsMap : ClassMap<ModelResults>
    {
        public ModelResultsMap()
        {
            Map(x => x.Date).Name("Date");
            Map(x => x.Contract).Name("Contract");
            Map(x => x.NewTradeAction).Name("New Trade Action");
            Map(x => x.Position).Name("Position");
            Map(x => x.Price).Name("Price");
            Map(x => x.PnlDaily).Name("Pnl Daily");
        }
    }
}
