using System;
using System.Collections.Generic;
using System.Text;

namespace CourseProject.Data.Contracts.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Section { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
    }
}
