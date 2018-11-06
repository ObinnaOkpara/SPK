namespace DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("spkmodel.accountants")]
    public partial class accountant
    {
        public int id { get; set; }

        [StringLength(50)]
        public string title { get; set; }

        [StringLength(200)]
        public string fullname { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string address { get; set; }

        [StringLength(20)]
        public string phone { get; set; }

        [StringLength(50)]
        public string state { get; set; }

        [StringLength(100)]
        public string lga { get; set; }

        [StringLength(100)]
        public string nationality { get; set; }

        [StringLength(100)]
        public string email { get; set; }

        [StringLength(100)]
        public string password { get; set; }

        [StringLength(50)]
        public string date_of_reg { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? time_of_reg { get; set; }
    }
}
