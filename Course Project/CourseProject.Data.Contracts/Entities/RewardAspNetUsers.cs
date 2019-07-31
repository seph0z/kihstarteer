using System;
using System.Collections.Generic;
using System.Text;

namespace CourseProject.Data.Contracts.Entities
{
    public class RewardAspNetUsers
    {
        public int RewardId { get; set; }
        public virtual Reward Reward { get; set; }

        public string UserId { get; set; }
        public virtual AspNetUsers User { get; set; }
    }
}
