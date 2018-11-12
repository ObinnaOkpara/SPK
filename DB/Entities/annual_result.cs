namespace DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("spkmodel.annual_result")]
    public partial class annual_result
    {
        public int id { get; set; }

        [Column("class")]
        [StringLength(20)]
        public string _class { get; set; }

        [StringLength(50)]
        public string session { get; set; }

        [StringLength(100)]
        public string reg_number { get; set; }

        [StringLength(100)]
        public string name { get; set; }

        [StringLength(100)]
        public string subjects { get; set; }

        public int? ca1 { get; set; }

        public int? project1 { get; set; }

        public int? exam1 { get; set; }

        public int? total1 { get; set; }

        public int? ca2 { get; set; }

        public int? project2 { get; set; }

        public int? exam2 { get; set; }

        public int? total2 { get; set; }

        public int? ca3 { get; set; }

        public int? project3 { get; set; }

        public int? exam3 { get; set; }

        public int? total3 { get; set; }
    }
}
