using System;
using System.Collections.Generic;
using System.Text;

namespace Kehstartir.Data.Contracts.Entities
{
    public class Image
    {
        public int Id { get; set; }
        public string ImagePath { get; set; }
        public int CampaignId { get; set; }
        public virtual Campaign Campaign { get; set; }
    }
}
