using System;
using System.Collections.Generic;
using System.Text;

namespace CourseProject.Data.Contracts.Entities
{
    public class Profile
    {
        public int Id { get; set; }
        public string Image { get; set; }

        public string UserId { get; set; }
        public virtual AspNetUsers User { get; set; }
    }
}
