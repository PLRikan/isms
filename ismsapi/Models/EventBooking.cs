using System;
using System.Collections.Generic;

namespace ismsapi.Models
{
    public partial class EventBooking
    {
        public long Id { get; set; }
        public int EventId { get; set; }
        public string NameFirst { get; set; }
        public string NameMiddle { get; set; }
        public string NameLast { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public virtual Event Event { get; set; }
    }
}
