using System;
using System.Collections.Generic;
using System.Text;

namespace Kehstartir.Data.Contracts.Entities
{
    public class Campaign
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public string VideoLink { get; set; }
        public double Amount { get; set; }
        public DateTime ExpirationDate { get; set; }

        public int ThemeId { get; set; }
        public virtual Theme Theme { get; set; }
        public string UserId { get; set; }
        public virtual AspNetUsers User { get; set; }
        public virtual ICollection<CampaignTag> CampaignTags { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Image> Images { get; set; }
        public virtual ICollection<BonusCampaign> BonusCampaigns { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
        public virtual Rating Rating { get; set; }
    }
}
