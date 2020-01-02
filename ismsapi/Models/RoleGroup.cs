using System;
using System.Collections.Generic;

namespace ismsapi.Models
{
    public partial class RoleGroup
    {
        public RoleGroup()
        {
            Admin = new HashSet<Admin>();
            Lecturer = new HashSet<Lecturer>();
            RoleDetail = new HashSet<RoleDetail>();
            Student = new HashSet<Student>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Admin> Admin { get; set; }
        public virtual ICollection<Lecturer> Lecturer { get; set; }
        public virtual ICollection<RoleDetail> RoleDetail { get; set; }
        public virtual ICollection<Student> Student { get; set; }
    }
}
