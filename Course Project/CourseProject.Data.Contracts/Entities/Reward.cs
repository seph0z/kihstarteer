using System;
using System.Collections.Generic;
using System.Text;

namespace CourseProject.Data.Contracts.Entities
{
    public class Reward
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Amount { get; set; }
        public string Description { get; set; }

        public int ProjectId { get; set; }
        public virtual Project Project { get; set; }
    }
}
