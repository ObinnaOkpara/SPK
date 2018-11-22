namespace DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("spkmodel.students")]
    public partial class student
    {
        public int id { get; set; }

        [StringLength(20)]
        public string gender { get; set; }

        [StringLength(50)]
        public string firstname { get; set; }

        [StringLength(50)]
        public string lastname { get; set; }

        [StringLength(50)]
        public string othername { get; set; }

        [StringLength(50)]
        public string dob { get; set; }

        [StringLength(50)]
        public string mob { get; set; }

        [StringLength(50)]
        public string yob { get; set; }

        [StringLength(20)]
        public string contact_phone { get; set; }

        [StringLength(100)]
        public string nearest_contact1 { get; set; }

        [StringLength(100)]
        public string nearest_contact2 { get; set; }

        [StringLength(100)]
        public string nearest_contact3 { get; set; }

        [StringLength(200)]
        public string health_conditions { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string address { get; set; }

        [StringLength(150)]
        public string father_name { get; set; }

        [StringLength(150)]
        public string father_occupation { get; set; }

        [StringLength(20)]
        public string father_phone { get; set; }

        [StringLength(150)]
        public string mother_name { get; set; }

        [StringLength(150)]
        public string mother_occupation { get; set; }

        [StringLength(20)]
        public string mother_phone { get; set; }

        [StringLength(50)]
        public string state { get; set; }

        [StringLength(200)]
        public string lga { get; set; }

        [StringLength(200)]
        public string city { get; set; }

        [StringLength(50)]
        public string nationality { get; set; }

        [StringLength(50)]
        public string sponsor_name { get; set; }

        [StringLength(20)]
        public string sponsor_phone { get; set; }

        [StringLength(200)]
        public string sponsor_address { get; set; }

        [StringLength(200)]
        public string sponsor_occupation { get; set; }

        [StringLength(20)]
        public string relationship { get; set; }

        [StringLength(250)]
        public string previous_school { get; set; }

        [StringLength(50)]
        public string last_class_passed { get; set; }

        [Column("class")]
        [StringLength(20)]
        public string _class { get; set; }

        [StringLength(100)]
        public string reg_number { get; set; }

        [StringLength(20)]
        public string gen_password { get; set; }

        [StringLength(255)]
        public string passport { get; set; }

        [StringLength(20)]
        public string date_of_reg { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? time_of_reg { get; set; }

        [NotMapped]
        public string Fullname { get
            {
                if (string.IsNullOrEmpty(firstname) || string.IsNullOrEmpty(othername)) return null;

                return firstname.Trim() + " " + lastname.Trim() + " " + othername.Trim();
            }
        }
        
        [NotMapped]
        public string AttendanceDummy { get; set; } = "Present";
    }
}
