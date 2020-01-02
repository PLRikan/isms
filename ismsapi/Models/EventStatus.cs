using System;
using System.Collections.Generic;

namespace ismsapi.Models
{
    public partial class EventStatus
    {
        public EventStatus()
        {
            Event = new HashSet<Event>();
        }

        public int Id { get; set; }
        public string Status { get; set; }

        public virtual ICollection<Event> Event { get; set; }
    }
}
