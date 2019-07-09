using System;
using System.Collections.Generic;
using System.Text;

namespace Kehstartir.Data.Contracts.Entities
{
    public class Rating
    {
        public int Id { get; set; }
        public double Sum { get; set; }
        public int Count { get; set; }

        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }
        public virtual ICollection<RatingAspNetUsers> RatingAspNetUsers { get; set; }
    }
}
