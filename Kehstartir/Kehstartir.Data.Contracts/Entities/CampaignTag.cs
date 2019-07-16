using System;
using System.Collections.Generic;
using System.Text;

namespace Kehstartir.Data.Contracts.Entities
{
    public class CampaignTag
    {
        public int CampaignId { get; set; }
        public virtual Campaign Campaign { get; set; }

        public int TagId { get; set; }
        public virtual Tag Tag { get; set; }
    }
}
