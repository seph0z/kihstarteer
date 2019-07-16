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

        public int CampaignId { get; set; }
        public virtual Campaign Campaign { get; set; }
        public virtual ICollection<RatingAspNetUsers> RatingAspNetUsers { get; set; }
    }
}
