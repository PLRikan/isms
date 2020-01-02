using System;
using System.Collections.Generic;

namespace ismsapi.Models
{
    public partial class TutionStatus
    {
        public TutionStatus()
        {
            BankAccount = new HashSet<BankAccount>();
        }

        public int Id { get; set; }
        public string Status { get; set; }

        public virtual ICollection<BankAccount> BankAccount { get; set; }
    }
}
