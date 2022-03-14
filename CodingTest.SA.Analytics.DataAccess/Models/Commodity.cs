using System.Collections.Generic;

namespace CodingTest.SA.Analytics.DataAccess.Models
{
    public class Commodity : BaseModel
    {
        public virtual ICollection<ModelResult> ModelResult { get; set; }
    }
}
