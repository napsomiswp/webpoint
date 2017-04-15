namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InsptIndebtednessSummary")]
    public partial class InsptIndebtednessSummary
    {
        [StringLength(11)]
        public string ferno { get; set; }

        [StringLength(200)]
        public string femp_name { get; set; }

        public int? flastLFNo { get; set; }

        [StringLength(3)]
        public string floc { get; set; }

        [StringLength(6)]
        public string flastcr_period { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ftotalcr_amt { get; set; }

        public DateTime? flastpay_date { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ftotalpay_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ftotalint_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ftotalint_paid { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ftotalintpen_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ftotalintpen_paid { get; set; }

        [StringLength(20)]
        public string Createdby { get; set; }

        public DateTime? Createdon { get; set; }

        [StringLength(20)]
        public string Modifiedby { get; set; }

        public DateTime? Modifiedon { get; set; }

        [Key]
        public int ID_SBTS { get; set; }
    }
}
