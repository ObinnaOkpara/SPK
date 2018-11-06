namespace DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("spkmodel.sss_subject_number")]
    public partial class sss_subject_number
    {
        public int id { get; set; }

        public int? number_of_subject { get; set; }

        [StringLength(20)]
        public string declared_date { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? declared_time { get; set; }
    }
}
