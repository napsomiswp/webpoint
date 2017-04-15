namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class eneg_mst
    {
        [StringLength(11)]
        public string ferno { get; set; }

        [StringLength(6)]
        public string fcb_perd { get; set; }

        [StringLength(6)]
        public string fce_perd { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fneg_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fcrbal { get; set; }

        [StringLength(6)]
        public string farr_date { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fpenbal { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ftinterest { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ftnegpay { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? fneg_date { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? flpaydate { get; set; }

        [StringLength(40)]
        public string fest_rep { get; set; }

        [StringLength(40)]
        public string fwitness { get; set; }

        [StringLength(1)]
        public string fstatus { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ft_date { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? fdateupd { get; set; }

        [StringLength(25)]
        public string CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        [StringLength(25)]
        public string ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool? DeleteFlag { get; set; }

        [Key]
        public int ID_SBTS { get; set; }
    }
}
