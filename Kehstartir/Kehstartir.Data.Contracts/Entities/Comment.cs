using System;
using System.Collections.Generic;
using System.Text;

namespace Kehstartir.Data.Contracts.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime Created { get; set; }

        public string UserId { get; set; }
        public virtual AspNetUsers User { get; set; }
        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }
        public virtual Like Like { get; set; }
    }
}
