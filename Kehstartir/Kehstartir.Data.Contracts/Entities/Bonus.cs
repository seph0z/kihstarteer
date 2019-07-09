using System;
using System.Collections.Generic;
using System.Text;

namespace Kehstartir.Data.Contracts.Entities
{
    public class Bonus
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }

        public virtual ICollection<BonusCompany> BonusCompanies { get; set; }
        public virtual ICollection<BonusAspNetUsers> BonusAspNetUsers { get; set; }
    }
}
