namespace DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("spkmodel.inventory")]
    public partial class inventory
    {
        public int id { get; set; }

        [StringLength(50)]
        public string type { get; set; }

        public int? cost { get; set; }

        [StringLength(250)]
        public string name { get; set; }

        public int? quantity { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string description { get; set; }

        [StringLength(50)]
        public string date { get; set; }
    }
}
