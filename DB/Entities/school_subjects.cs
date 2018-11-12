namespace DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("spkmodel.school_subjects")]
    public partial class school_subjects
    {
        public int id { get; set; }

        [StringLength(111)]
        public string subjects { get; set; }

        [StringLength(111)]
        public string date_saved { get; set; }
    }
}
