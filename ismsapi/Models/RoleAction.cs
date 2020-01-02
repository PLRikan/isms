using System;
using System.Collections.Generic;

namespace ismsapi.Models
{
    public partial class RoleAction
    {
        public RoleAction()
        {
            RoleDetail = new HashSet<RoleDetail>();
        }

        public int Id { get; set; }
        public string Action { get; set; }
        public string ShortCode { get; set; }
        public string Description { get; set; }

        public virtual ICollection<RoleDetail> RoleDetail { get; set; }
    }
}
