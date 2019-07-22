using System;
using System.Collections.Generic;
using System.Text;

namespace CourseProject.Data.Contracts.Entities
{
    class Content
    {
        public int Id { get; set; }
        public string Text { get; set; }

        public int ProjectId { get; set; }
        public virtual Project Project { get; set; }
    }
}
