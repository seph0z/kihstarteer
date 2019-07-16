using System;
using System.Collections.Generic;
using System.Text;

namespace Kehstartir.Data.Contracts.Entities
{
    public class Theme
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Campaign> Campaigns { get; set; }
    }
}
