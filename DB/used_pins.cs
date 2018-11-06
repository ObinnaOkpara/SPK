namespace DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("spkmodel.used_pins")]
    public partial class used_pins
    {
        public int id { get; set; }

        [Column("used_pins")]
        [StringLength(50)]
        public string used_pins1 { get; set; }

        [StringLength(50)]
        public string user_reg_number { get; set; }

        public int? used_count { get; set; }

        [StringLength(50)]
        public string user_class { get; set; }

        [StringLength(50)]
        public string used_term { get; set; }

        [StringLength(50)]
        public string used_session { get; set; }

        [StringLength(50)]
        public string date_used { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? time_used { get; set; }
    }
}
