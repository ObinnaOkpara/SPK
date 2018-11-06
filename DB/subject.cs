namespace DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("spkmodel.subjects")]
    public partial class subject
    {
        public int id { get; set; }

        [StringLength(100)]
        public string reg_number { get; set; }

        [StringLength(100)]
        public string name { get; set; }

        [Column("class")]
        [StringLength(20)]
        public string _class { get; set; }

        [StringLength(100)]
        public string subjects { get; set; }

        [StringLength(50)]
        public string term { get; set; }

        [StringLength(50)]
        public string session { get; set; }

        [StringLength(20)]
        public string registration_date { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? registration_time { get; set; }
    }
}
