namespace DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("spkmodel.behavioral")]
    public partial class behavioral
    {
        public int id { get; set; }

        [StringLength(100)]
        public string reg_number { get; set; }

        [StringLength(250)]
        public string name { get; set; }

        [Column("class")]
        [StringLength(50)]
        public string _class { get; set; }

        [StringLength(50)]
        public string term { get; set; }

        [StringLength(50)]
        public string session { get; set; }

        [StringLength(11)]
        public string hand_writting { get; set; }

        [StringLength(11)]
        public string musical_skills { get; set; }

        [StringLength(11)]
        public string sports { get; set; }

        [StringLength(11)]
        public string attentiveness { get; set; }

        [StringLength(11)]
        public string attitude_to_work { get; set; }

        [StringLength(11)]
        public string health { get; set; }

        [StringLength(11)]
        public string politeness { get; set; }

        [StringLength(50)]
        public string date { get; set; }
    }
}
