namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class c_penbnks
    {
        [StringLength(3)]
        public string floc { get; set; }

        [StringLength(75)]
        public string floc_name { get; set; }

        public int? fno_paid { get; set; }

        public int? fno_paid1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ftot_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ftot_amt1 { get; set; }

        [Key]
        public int ID_SBTS { get; set; }

        [StringLength(20)]
        public string CREATEDBY { get; set; }

        public DateTime? CREATEDON { get; set; }

        [StringLength(20)]
        public string MODIFIEDBY { get; set; }

        public DateTime? MODIFIEDON { get; set; }
    }
}
