namespace DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("spkmodel.dates")]
    public partial class date
    {
        public int id { get; set; }

        [StringLength(50)]
        public string end_of_term { get; set; }

        [StringLength(50)]
        public string next_term_begins { get; set; }

        [StringLength(50)]
        public string date_declared { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? time_declared { get; set; }
    }
}
