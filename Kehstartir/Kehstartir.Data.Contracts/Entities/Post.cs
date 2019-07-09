﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Kehstartir.Data.Contracts.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        
        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }
        public string UserId { get; set; }
        public virtual AspNetUsers User { get; set; }
    }
}