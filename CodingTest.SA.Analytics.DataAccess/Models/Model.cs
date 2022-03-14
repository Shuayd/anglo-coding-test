using System;
using System.Collections.Generic;

namespace CodingTest.SA.Analytics.DataAccess.Models
{
    public class Model : BaseModel
    {
        public virtual ICollection<ModelResult> ModelResult { get; set; }
    }
}
