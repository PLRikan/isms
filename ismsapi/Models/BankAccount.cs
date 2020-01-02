using System;
using System.Collections.Generic;

namespace ismsapi.Models
{
    public partial class BankAccount
    {
        public BankAccount()
        {
            Student = new HashSet<Student>();
        }

        public int Id { get; set; }
        public int TutionStatus { get; set; }
        public string AccountNumber { get; set; }
        public string BankName { get; set; }
        public int TutionDebt { get; set; }

        public virtual TutionStatus TutionStatusNavigation { get; set; }
        public virtual ICollection<Student> Student { get; set; }
    }
}
