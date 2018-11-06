namespace DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("spkmodel.teachers_classes")]
    public partial class teachers_classes
    {
        public int id { get; set; }

        [StringLength(100)]
        public string name { get; set; }

        [StringLength(100)]
        public string subject { get; set; }

        [Column("class")]
        [StringLength(20)]
        public string _class { get; set; }

        [StringLength(50)]
        public string term { get; set; }
    }
}
