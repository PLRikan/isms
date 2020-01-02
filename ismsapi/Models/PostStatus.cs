using System;
using System.Collections.Generic;

namespace ismsapi.Models
{
    public partial class PostStatus
    {
        public PostStatus()
        {
            Post = new HashSet<Post>();
        }

        public int Id { get; set; }
        public string Status { get; set; }

        public virtual ICollection<Post> Post { get; set; }
    }
}
