using System;
using System.Collections.Generic;
using System.Text;

namespace Kehstartir.Data.Contracts.Entities
{
    public class BonusCompany
    {
        public int BonusId { get; set; }
        public virtual Bonus Bonus { get; set; }

        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }
    }
}
