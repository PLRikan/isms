using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ismsapi.ViewModel
{
    public class StudentRowIndex
    {
        public int Id { get; set; }
        public string StudentCode { get; set; }
        public string NameFirst { get; set; }
        public string NameMiddle { get; set; }
        public string NameLast { get; set; }
        public string FacultyName { get; set; }
        public string MajorName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string StudyStatus { get; set; }
        public int TuitionStatus { get; set; }
    }
}
