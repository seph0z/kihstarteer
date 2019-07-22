using System;
using System.Collections.Generic;
using System.Text;

namespace CourseProject.Data.Contracts.Entities
{
    public class Image
    {
        public int Id { get; set; }
        public string Path { get; set; }

        public int ProjectId { get; set; }
        public virtual Project Project { get; set; }
    }
}
