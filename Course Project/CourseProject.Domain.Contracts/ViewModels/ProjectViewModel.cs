using System;
using System.Collections.Generic;
using System.Text;

namespace CourseProject.Domain.Contracts.ViewModels
{
    public class ProjectViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Image { get; set; }
        public string Video { get; set; }
        public string Content { get; set; }
        public double Funding { get; set; }
        public DateTime Duration { get; set; }
        public string Category { get; set; }
        public string UserId { get; set; }
    }
}
