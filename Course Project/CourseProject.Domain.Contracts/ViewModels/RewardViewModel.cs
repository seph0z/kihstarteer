using System;
using System.Collections.Generic;
using System.Text;

namespace CourseProject.Domain.Contracts.ViewModels
{
    public class RewardViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Amount { get; set; }
        public string Description { get; set; }

        public int ProjectId { get; set; }
    }
}
