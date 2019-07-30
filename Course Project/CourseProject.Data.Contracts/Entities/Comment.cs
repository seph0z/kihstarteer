using System;
using System.Collections.Generic;
using System.Text;

namespace CourseProject.Data.Contracts.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }

        public string UserId { get; set; }
        public virtual AspNetUsers User { get; set; }

        public int ProjectId { get; set; }
        public virtual Project Project { get; set; }
    }
}
