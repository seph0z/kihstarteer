using System;
using System.Collections.Generic;
using System.Text;

namespace CourseProject.Data.Contracts.Entities
{
    public class Tag
    {
        public int Id { get; set; }
        public string Text { get; set; }

        public virtual ICollection<ProjectTag> ProjectTags { get; set; }
    }
}
