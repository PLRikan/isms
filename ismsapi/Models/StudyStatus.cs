using System;
using System.Collections.Generic;

namespace ismsapi.Models
{
    public partial class StudyStatus
    {
        public StudyStatus()
        {
            Lecturer = new HashSet<Lecturer>();
            Student = new HashSet<Student>();
        }

        public int Id { get; set; }
        public string Status { get; set; }

        public virtual ICollection<Lecturer> Lecturer { get; set; }
        public virtual ICollection<Student> Student { get; set; }
    }
}
