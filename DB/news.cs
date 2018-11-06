namespace DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("spkmodel.news")]
    public partial class news
    {
        public int id { get; set; }

        [StringLength(100)]
        public string header { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string body { get; set; }

        [StringLength(50)]
        public string news_date { get; set; }
    }
}
