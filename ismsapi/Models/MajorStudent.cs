using System;
using System.Collections.Generic;

namespace ismsapi.Models
{
    public partial class MajorStudent
    {
        public MajorStudent()
        {
            Student = new HashSet<Student>();
        }

        public int Id { get; set; }
        public int FacultyId { get; set; }
        public string ShortCode { get; set; }
        public string Major { get; set; }

        public virtual Faculty Faculty { get; set; }
        public virtual ICollection<Student> Student { get; set; }
    }
}
