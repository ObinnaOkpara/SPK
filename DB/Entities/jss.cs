namespace DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("spkmodel.jss")]
    public partial class jss
    {
        public int id { get; set; }

        [StringLength(100)]
        public string jss_subjects { get; set; }

        [StringLength(50)]
        public string upload_date { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? upload_time { get; set; }
    }
}
