using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ismsapi.ViewModel
{
    public class EventDetail
    {
        public int Id { get; set; }
        public int EventStatusId { get; set; }
        public string EventStatusName { get; set; }
        public string Name { get; set; }
        public string Thumbnail { get; set; }
        public string Content { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
    }
}
