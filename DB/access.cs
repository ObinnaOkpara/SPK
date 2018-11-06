namespace DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("spkmodel.access")]
    public partial class access
    {
        public int id { get; set; }

        [StringLength(50)]
        public string control_access { get; set; }

        [StringLength(50)]
        public string date_created { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? time_created { get; set; }
    }
}
