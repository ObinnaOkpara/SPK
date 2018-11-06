namespace DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("spkmodel.mail")]
    public partial class mail
    {
        public int id { get; set; }

        [StringLength(200)]
        public string name { get; set; }

        [StringLength(200)]
        public string email { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string message { get; set; }

        [StringLength(50)]
        public string mail_date { get; set; }
    }
}
