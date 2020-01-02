using System;
using System.Collections.Generic;

namespace ismsapi.Models
{
    public partial class MajorLecturer
    {
        public MajorLecturer()
        {
            Lecturer = new HashSet<Lecturer>();
        }

        public int Id { get; set; }
        public string ShortCode { get; set; }
        public string Major { get; set; }
        public string University { get; set; }
        public string Country { get; set; }
        public string Faculty { get; set; }

        public virtual ICollection<Lecturer> Lecturer { get; set; }
    }
}
