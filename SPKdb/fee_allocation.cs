using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPKdb
{
    class fee_allocation
    {
        public int id { get; set; }
        public string allocate_class { get; set; }
        public string student_type { get; set; }
        public int fee_amount { get; set; }
        public string date_allocated { get; set; }
    }
}
