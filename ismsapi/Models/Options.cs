using System;
using System.Collections.Generic;

namespace ismsapi.Models
{
    public partial class Options
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? DateModify { get; set; }
    }
}
