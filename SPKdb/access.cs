using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPKdb
{
    public class access
    {
        public int id { get; set; }
        public string control_access { get; set; }
        public string date_created { get; set; }
        public TimeSpan time_created { get; set; }
    }
}
