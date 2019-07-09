using System;
using System.Collections.Generic;
using System.Text;

namespace Kehstartir.Data.Contracts.Entities
{
    public class RatingAspNetUsers
    {
        public int RatingId { get; set; }
        public virtual Rating Rating { get; set; }

        public string UserId { get; set; }
        public virtual AspNetUsers User { get; set; }
    }
}
