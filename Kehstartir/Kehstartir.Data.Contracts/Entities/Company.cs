using System;
using System.Collections.Generic;
using System.Text;

namespace Kehstartir.Data.Contracts.Entities
{
    public class Company
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string VideoLink { get; set; }
        public double Amount { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Theme { get; set; }
        
        public string UserId { get; set; }
        public virtual AspNetUsers User { get; set; }
        public virtual ICollection<CompanyTag> CompanyTags { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Image> Images { get; set; }
        public virtual ICollection<BonusCompany> BonusCompanies { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
        public virtual Rating Rating { get; set; }
    }
}
