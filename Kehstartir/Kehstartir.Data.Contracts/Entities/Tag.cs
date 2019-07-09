using System;
using System.Collections.Generic;
using System.Text;

namespace Kehstartir.Data.Contracts.Entities
{
    public class Tag
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public virtual ICollection<CompanyTag> CompanyTags { get; set; }
    }
}
