using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPKdb
{
    class dates
    {
        public int id { get; set; }
        public string end_of_term { get; set; }
        public string next_term_begins { get; set; }
        public string date_declared { get; set; }
        public TimeSpan? time_declared { get; set; }
    }
}
