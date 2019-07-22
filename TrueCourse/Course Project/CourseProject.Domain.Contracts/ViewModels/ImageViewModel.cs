using System;
using System.Collections.Generic;
using System.Text;

namespace CourseProject.Domain.Contracts.ViewModels
{
    public class ImageViewModel
    {
        public int Id { get; set; }
        public string Path { get; set; }
        public int ProjectId { get; set; }
    }
}
