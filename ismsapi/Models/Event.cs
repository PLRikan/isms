using System;
using System.Collections.Generic;

namespace ismsapi.Models
{
    public partial class Event
    {
        public Event()
        {
            EventBooking = new HashSet<EventBooking>();
        }

        public int Id { get; set; }
        public int EventStatusId { get; set; }
        public string Name { get; set; }
        public string Thumbnail { get; set; }
        public string Content { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }

        public virtual EventStatus EventStatus { get; set; }
        public virtual ICollection<EventBooking> EventBooking { get; set; }
    }
}
