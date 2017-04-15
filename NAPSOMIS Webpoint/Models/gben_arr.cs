namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class gben_arr
    {
        [StringLength(12)]
        public string fclaim_no { get; set; }

        public decimal? famount { get; set; }

        [StringLength(6)]
        public string fb_perd { get; set; }

        [StringLength(6)]
        public string fe_perd { get; set; }

        [StringLength(6)]
        public string fpaid_perd { get; set; }

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
