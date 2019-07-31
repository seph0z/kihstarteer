using System;
using System.Collections.Generic;
using System.Text;

namespace CourseProject.Domain.Contracts.ViewModels
{
    public class CommentViewModel
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime Create { get; set; }

        public string UserId { get; set; }  
        public string UserName { get; set; }
        public string UserImage { get; set; }

        public int ProjectId { get; set; }
    }
}
