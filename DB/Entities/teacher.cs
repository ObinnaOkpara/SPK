namespace DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("spkmodel.teachers")]
    public partial class teacher
    {
        public int id { get; set; }

        [StringLength(100)]
        public string username { get; set; }

        [StringLength(100)]
        public string password { get; set; }

        [StringLength(100)]
        public string firstname { get; set; }

        [StringLength(100)]
        public string lastname { get; set; }

        [StringLength(50)]
        public string employment_date { get; set; }

        [StringLength(100)]
        public string teacher_position { get; set; }

        [StringLength(100)]
        public string subject_to_teach { get; set; }

        [StringLength(100)]
        public string lga { get; set; }

        [StringLength(100)]
        public string state { get; set; }

        [StringLength(100)]
        public string country { get; set; }

        [StringLength(50)]
        public string sex { get; set; }

        [StringLength(10)]
        public string dob { get; set; }

        [StringLength(50)]
        public string mob { get; set; }

        [StringLength(10)]
        public string yob { get; set; }

        [StringLength(200)]
        public string address { get; set; }

        [StringLength(50)]
        public string phone { get; set; }

        [StringLength(100)]
        public string email { get; set; }

        [StringLength(50)]
        public string status { get; set; }

        [StringLength(50)]
        public string date_registered { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? time_registered { get; set; }


        [NotMapped]
        public string Fullname { get { return this.firstname.Trim() + " " + this.lastname.Trim(); } }
    }
}
