using System;
using System.Collections.Generic;
using System.Text;

namespace Kehstartir.Data.Contracts.Entities
{
    public class BonusCampaign
    {
        public int BonusId { get; set; }
        public virtual Bonus Bonus { get; set; }

        public int CampaignId { get; set; }
        public virtual Campaign Campaign { get; set; }
    }
}
