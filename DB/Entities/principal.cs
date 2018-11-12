namespace DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("spkmodel.principal")]
    public partial class principal
    {
        public int id { get; set; }

        [StringLength(100)]
        public string username { get; set; }

        [StringLength(50)]
        public string password { get; set; }

        [StringLength(100)]
        public string firstname { get; set; }

        [StringLength(100)]
        public string lastname { get; set; }

        [StringLength(100)]
        public string position { get; set; }

        [StringLength(20)]
        public string sex { get; set; }

        [StringLength(20)]
        public string phone { get; set; }

        [StringLength(100)]
        public string email { get; set; }

        [StringLength(100)]
        public string next_of_kin { get; set; }

        [StringLength(100)]
        public string next_of_kin_relationship { get; set; }

        [StringLength(50)]
        public string next_of_kin_phone { get; set; }

        [StringLength(50)]
        public string date_registered { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? time_registered { get; set; }
    }
}
