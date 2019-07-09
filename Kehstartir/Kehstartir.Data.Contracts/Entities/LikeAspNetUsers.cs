using System;
using System.Collections.Generic;
using System.Text;

namespace Kehstartir.Data.Contracts.Entities
{
    public class LikeAspNetUsers
    {
        public int LikeId { get; set; }
        public virtual Like Like { get; set; }

        public string UserId { get; set; }
        public virtual AspNetUsers User { get; set; }
    }
}
