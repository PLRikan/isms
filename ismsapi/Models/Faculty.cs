using System;
using System.Collections.Generic;

namespace ismsapi.Models
{
    public partial class Faculty
    {
        public Faculty()
        {
            Lecturer = new HashSet<Lecturer>();
            MajorStudent = new HashSet<MajorStudent>();
            Student = new HashSet<Student>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public virtual ICollection<Lecturer> Lecturer { get; set; }
        public virtual ICollection<MajorStudent> MajorStudent { get; set; }
        public virtual ICollection<Student> Student { get; set; }
    }
}
