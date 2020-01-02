using System;
using System.Collections.Generic;

namespace ismsapi.Models
{
    public partial class RoleDetail
    {
        public int Id { get; set; }
        public int RoleGroupId { get; set; }
        public int RoleActionId { get; set; }
        public int Allow { get; set; }

        public virtual RoleAction RoleAction { get; set; }
        public virtual RoleGroup RoleGroup { get; set; }
    }
}
