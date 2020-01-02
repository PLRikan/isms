using System;
using System.Collections.Generic;

namespace ismsapi.Models
{
    public partial class StudyType
    {
        public StudyType()
        {
            Lecturer = new HashSet<Lecturer>();
            Student = new HashSet<Student>();
        }

        public int Id { get; set; }
        public string Type { get; set; }

        public virtual ICollection<Lecturer> Lecturer { get; set; }
        public virtual ICollection<Student> Student { get; set; }
    }
}
