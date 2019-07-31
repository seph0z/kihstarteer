using System;
using System.Collections.Generic;
using System.Text;

namespace CourseProject.Domain.Contracts.ViewModels
{
    public class ShowProjectViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Image { get; set; }
        public string Video { get; set; }
        public double CurrentFunding { get; set; }
        public double Funding { get; set; }
        public DateTime Duration { get; set; }
        public string Content { get; set; }
        public string Category { get; set; }
        public string User { get; set; }
        public ICollection<RewardViewModel> Rewards { get; set; }
        public ICollection<PostViewModel> Posts { get; set; }
        public ICollection<CommentViewModel> Comments { get; set; }
        public string[] Images { get; set; }
        public string[] Tags { get; set; }
    }
}
