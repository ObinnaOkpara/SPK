namespace DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("spkmodel.classes")]
    public partial class _class
    {
        public int id { get; set; }

        [StringLength(50)]
        public string classes { get; set; }

        [StringLength(50)]
        public string date_added { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? time_added { get; set; }
    }
}
