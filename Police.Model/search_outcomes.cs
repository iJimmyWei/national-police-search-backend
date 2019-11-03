namespace Police.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class search_outcomes
    {
        public int id { get; set; }

        [StringLength(200)]
        public string crime_id { get; set; }

        public int? year { get; set; }

        public int? month { get; set; }

        [StringLength(2000)]
        public string reported_by { get; set; }

        [StringLength(2000)]
        public string falls_within { get; set; }

        [Column("long")]
        public double? _long { get; set; }

        public double? lat { get; set; }

        [StringLength(2000)]
        public string location { get; set; }

        [StringLength(2000)]
        public string lsoa_code { get; set; }

        public int? crime_type_id { get; set; }

        public int? last_outcome_id { get; set; }

        [StringLength(2000)]
        public string context { get; set; }
    }
}
