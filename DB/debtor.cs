namespace DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("spkmodel.debtors")]
    public partial class debtor
    {
        public int id { get; set; }

        [StringLength(250)]
        public string name { get; set; }

        public int? amount { get; set; }

        [StringLength(50)]
        public string phone { get; set; }

        [StringLength(50)]
        public string deadline { get; set; }

        [StringLength(50)]
        public string date { get; set; }
    }
}
