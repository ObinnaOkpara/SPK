using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPKdb
{
    class current_season
    {
        public int id { get; set; }
        public string current_session_ { get; set; }
        public string current_term { get; set; }
        public string date_declared { get; set; }
        public TimeSpan? time_declared { get; set; }
    }
}
