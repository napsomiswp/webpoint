namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class gben_indx
    {
        [StringLength(20)]
        public string fyear { get; set; }

        public decimal? findx_rate { get; set; }

        public decimal? findx_amt { get; set; }

        public decimal? fbonus_rate { get; set; }

        public decimal? fbonus_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fbonus_sperd { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fbonus_eperd { get; set; }

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
