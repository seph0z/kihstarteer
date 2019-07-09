using System;
using System.Collections.Generic;
using System.Text;

namespace Kehstartir.Data.Contracts.Entities
{
    public class CompanyTag
    {
        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }

        public int TagId { get; set; }
        public virtual Tag Tag { get; set; }
    }
}
