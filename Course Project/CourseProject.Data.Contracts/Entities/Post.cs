using System;
using System.Collections.Generic;
using System.Text;

namespace CourseProject.Data.Contracts.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Content { get; set; }

        public string UserId { get; set; }
        public virtual AspNetUsers User { get; set; }

        public int ProjectId { get; set; }
        public virtual Project Project { get; set; }
    }
}
