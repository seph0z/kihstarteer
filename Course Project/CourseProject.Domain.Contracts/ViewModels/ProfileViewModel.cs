using System;
using System.Collections.Generic;
using System.Text;

namespace CourseProject.Domain.Contracts.ViewModels
{
    public class ProfileViewModel
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string UserId { get; set; }
    }
}
