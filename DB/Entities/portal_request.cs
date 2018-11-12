namespace DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("spkmodel.portal_request")]
    public partial class portal_request
    {
        public int id { get; set; }

        [StringLength(200)]
        public string name { get; set; }

        [StringLength(200)]
        public string school_name { get; set; }

        [StringLength(150)]
        public string position_held { get; set; }

        [StringLength(200)]
        public string email { get; set; }

        [StringLength(20)]
        public string phone { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string message { get; set; }

        [StringLength(100)]
        public string request_date { get; set; }
    }
}
