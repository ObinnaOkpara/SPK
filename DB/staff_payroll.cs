namespace DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("spkmodel.staff_payroll")]
    public partial class staff_payroll
    {
        public int id { get; set; }

        [StringLength(250)]
        public string staff_name { get; set; }

        public int? salary { get; set; }

        public int? debit { get; set; }

        [StringLength(250)]
        public string debit_reason { get; set; }

        public int? bonus { get; set; }

        [StringLength(250)]
        public string bonus_reason { get; set; }

        public int? credit { get; set; }

        [StringLength(50)]
        public string date { get; set; }
    }
}
