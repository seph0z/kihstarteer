using System;
using System.Collections.Generic;
using System.Text;

namespace CourseProject.Data.Contracts.Entities
{
    public class Project
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Image { get; set; }
        public string Video { get; set; }
        public double Funding { get; set; }
        public DateTime Duration { get; set; }
        public string Content { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public string UserId { get; set; }
        public virtual AspNetUsers User { get; set; }

    }
}
