using System;
using System.Collections.Generic;

namespace ismsapi.Models
{
    public partial class Post
    {
        public int Id { get; set; }
        public int AdminId { get; set; }
        public int PostStatusId { get; set; }
        public int CategoryId { get; set; }
        public string Thumbnail { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? DateModify { get; set; }

        public virtual Admin Admin { get; set; }
        public virtual Category Category { get; set; }
        public virtual PostStatus PostStatus { get; set; }
    }
}
