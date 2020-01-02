using System;
using System.Collections.Generic;

namespace ismsapi.Models
{
    public partial class Admin
    {
        public Admin()
        {
            Post = new HashSet<Post>();
        }

        public int Id { get; set; }
        public int RoleGroupId { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string NameFirst { get; set; }
        public string NameMiddle { get; set; }
        public string NameLast { get; set; }

        public virtual RoleGroup RoleGroup { get; set; }
        public virtual ICollection<Post> Post { get; set; }
    }
}
