using System;
using System.Collections.Generic;

namespace ismsapi.Models
{
    public partial class Contact
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string NameFirst { get; set; }
        public string NameMiddle { get; set; }
        public string NameLast { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime DateSend { get; set; }
    }
}
