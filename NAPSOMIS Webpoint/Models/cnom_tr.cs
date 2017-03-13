namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class cnom_tr
    {
        public int? id { get; set; }

        [StringLength(20)]
        public string fref_no { get; set; }

        [StringLength(20)]
        public string fssno { get; set; }

        [StringLength(20)]
        public string fnom_ssno { get; set; }

        [StringLength(100)]
        public string fnsurname { get; set; }

        [StringLength(100)]
        public string fnfirstnam { get; set; }

        [StringLength(100)]
        public string fnothname { get; set; }

        [StringLength(10)]
        public string fnomsex { get; set; }

        public DateTime? fbirth_dat { get; set; }

        [StringLength(20)]
        public string frelation { get; set; }

        [StringLength(20)]
        public string frel_desc { get; set; }

        [StringLength(20)]
        public string fbatch_no { get; set; }

        [StringLength(200)]
        public string fper_addr { get; set; }

        [StringLength(200)]
        public string fres_addr { get; set; }

        [Key]
        public int idno { get; set; }
    }
}
