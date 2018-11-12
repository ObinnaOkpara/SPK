namespace DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("spkmodel.positions")]
    public partial class position
    {
        public int id { get; set; }

        [StringLength(100)]
        public string reg_number { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        [Column("class")]
        [StringLength(50)]
        public string _class { get; set; }

        [StringLength(50)]
        public string term { get; set; }

        [StringLength(50)]
        public string session { get; set; }

        public int? students_sub_total { get; set; }

        public float? students_sub_average { get; set; }

        public int? class_position { get; set; }

        [StringLength(20)]
        public string upload_date { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? upload_time { get; set; }
    }
}
