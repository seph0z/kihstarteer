using System;
using System.Collections.Generic;
using System.Text;

namespace Kehstartir.Data.Contracts.Entities
{
    public class Image
    {
        public int Id { get; set; }
        public string ImagePath { get; set; }
        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }
    }
}
