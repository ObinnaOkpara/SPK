namespace DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("spkmodel.results1")]
    public partial class results1
    {
        public int id { get; set; }

        [Column("class")]
        [StringLength(10)]
        public string _class { get; set; }

        [StringLength(10)]
        public string term { get; set; }

        [StringLength(50)]
        public string session { get; set; }

        [StringLength(50)]
        public string reg_number { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        [StringLength(100)]
        public string subjects { get; set; }

        public int? ca { get; set; }

        public int? project { get; set; }

        public int? exam { get; set; }

        public int? subject_total { get; set; }

        public int? subject_rank { get; set; }

        [StringLength(20)]
        public string date_of_upload { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime time_of_upload { get; set; }
    }
}
