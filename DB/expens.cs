namespace DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("spkmodel.expenses")]
    public partial class expens
    {
        public int id { get; set; }

        [StringLength(250)]
        public string paid_to { get; set; }

        [StringLength(250)]
        public string paid_for { get; set; }

        public int? amount_paid { get; set; }

        [StringLength(50)]
        public string phone { get; set; }

        [StringLength(50)]
        public string date { get; set; }
    }
}
