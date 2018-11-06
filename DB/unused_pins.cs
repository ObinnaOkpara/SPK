namespace DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("spkmodel.unused_pins")]
    public partial class unused_pins
    {
        public int id { get; set; }

        [StringLength(50)]
        public string term { get; set; }

        [Column("unused_pins")]
        [StringLength(100)]
        public string unused_pins1 { get; set; }

        [StringLength(100)]
        public string serial_number { get; set; }

        [StringLength(30)]
        public string upload_date { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? upload_time { get; set; }
    }
}
