using System;
using System.Collections.Generic;
using System.Text;

namespace Kehstartir.Data.Contracts.Entities
{
    public class BonusAspNetUsers
    {
        public int BonusId { get; set; }
        public virtual Bonus Bonus { get; set; }
        
        public string UserId { get; set; }
        public virtual AspNetUsers User { get; set; }
    }
}
