using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTest.SA.Analytics.DataAccess.Models
{
    public class Contract : BaseModel
    {
        public virtual ICollection<ModelResult> ModelResult { get; set; }
    }
}
