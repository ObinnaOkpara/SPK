namespace DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("spkmodel.fee_payment")]
    public partial class fee_payment
    {
        public int id { get; set; }

        [StringLength(100)]
        public string reg_number { get; set; }

        [StringLength(250)]
        public string student_name { get; set; }

        [StringLength(50)]
        public string student_class { get; set; }

        [StringLength(50)]
        public string student_type { get; set; }

        [StringLength(50)]
        public string fee_term { get; set; }

        [StringLength(50)]
        public string fee_session { get; set; }

        public int? amount_paid { get; set; }

        public int? student_balance { get; set; }

        [StringLength(50)]
        public string teller_no { get; set; }

        [StringLength(50)]
        public string payment_status { get; set; }

        [StringLength(50)]
        public string date_of_upload { get; set; }
    }
}
