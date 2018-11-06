namespace DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("spkmodel.student_attendance")]
    public partial class student_attendance
    {
        public int id { get; set; }

        [StringLength(100)]
        public string reg_number { get; set; }

        [StringLength(100)]
        public string name { get; set; }

        [StringLength(50)]
        public string date { get; set; }

        [StringLength(20)]
        public string term { get; set; }

        [StringLength(20)]
        public string session { get; set; }

        [Column("class")]
        [StringLength(20)]
        public string _class { get; set; }

        [StringLength(20)]
        public string roll_call { get; set; }
    }
}
