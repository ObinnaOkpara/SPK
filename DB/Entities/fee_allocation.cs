namespace DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("spkmodel.fee_allocation")]
    public partial class fee_allocation
    {
        public int id { get; set; }

        [StringLength(100)]
        public string allocate_class { get; set; }

        [StringLength(100)]
        public string student_type { get; set; }

        public int? fee_amount { get; set; }

        [StringLength(50)]
        public string date_allocated { get; set; }
    }
}
