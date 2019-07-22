using System;
using System.Collections.Generic;
using System.Text;

namespace CourseProject.Domain.Contracts.ViewModels
{
    public class ContentViewModel
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int ProjectId { get; set; }
    }
}
