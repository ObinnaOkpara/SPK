namespace DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("spkmodel.current_season")]
    public partial class current_season
    {
        public int id { get; set; }

        [StringLength(20)]
        public string current_session { get; set; }

        [StringLength(50)]
        public string current_term { get; set; }

        [StringLength(50)]
        public string date_declared { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? time_declared { get; set; }
    }
}
