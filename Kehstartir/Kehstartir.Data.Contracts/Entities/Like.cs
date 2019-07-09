using System;
using System.Collections.Generic;
using System.Text;

namespace Kehstartir.Data.Contracts.Entities
{
    public class Like
    {
        public int Id { get; set; }
        public int Up { get; set; }
        public int Down { get; set; }

        public int CommentId { get; set; }
        public virtual Comment Comment { get; set; }
        public virtual ICollection<LikeAspNetUsers> LikeAspNetUsers { get; set; }
    }
}
