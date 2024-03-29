﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CourseProject.Domain.Contracts.ViewModels
{
    public class ProjectViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        [Required]
        public string Subtitle { get; set; }
        public string Image { get; set; }
        public string Video { get; set; }
        public double CurrentFunding { get; set; }
        public double Funding { get; set; }
        public DateTime Duration { get; set; }
        public int CategoryId { get; set; }
        public string UserId { get; set; }
        public string[] Tags { get; set; }
    }
}
