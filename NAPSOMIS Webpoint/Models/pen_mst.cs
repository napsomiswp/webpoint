namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class pen_mst
    {
        [StringLength(17)]
        public string fbatch_no { get; set; }

        [StringLength(17)]
        public string fssno { get; set; }

        [StringLength(12)]
        public string fclaim_no { get; set; }

        [StringLength(3)]
        public string floc { get; set; }

        [StringLength(40)]
        public string fpaypoint { get; set; }

        [StringLength(1)]
        public string fsex { get; set; }

        [StringLength(11)]
        public string ferno { get; set; }

        public DateTime? fterm_date { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fterm_sal { get; set; }

        public DateTime? fapp_date { get; set; }

        [StringLength(2)]
        public string fbtype_opt { get; set; }

        [StringLength(2)]
        public string fbt_award { get; set; }

        [StringLength(1)]
        public string fpaymode { get; set; }

        [StringLength(1)]
        public string frequency { get; set; }

        [StringLength(1)]
        public string fstatus { get; set; }

        [StringLength(4)]
        public string fbest_1yr { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fbest_1amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fbest_1mth { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fb5_sal { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fb5_avg { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fgrant { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? flast_3mth { get; set; }

        public DateTime? fstart_date { get; set; }

        public DateTime? fdue_date { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fpen_right { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ftimes_paid { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ftotal_paid { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fmonth_sal { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fage { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fmths_cr { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fadd_mths { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? farrears { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fdeduction { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fpen_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fnet_pay { get; set; }

        [StringLength(6)]
        public string flpay_perd { get; set; }

        [StringLength(6)]
        public string fprev_eperd { get; set; }

        public DateTime? frec_date { get; set; }

        [StringLength(2)]
        public string ftype { get; set; }

        [StringLength(6)]
        public string findex_perd { get; set; }

        public DateTime? fjoin_date { get; set; }

        [StringLength(4)]
        public string fentry { get; set; }

        public DateTime? fstop_date { get; set; }

        public DateTime? fract_date { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? farr_deduct { get; set; }

        [StringLength(7)]
        public string fpay_pnt { get; set; }

        public DateTime? fdateupd { get; set; }

        [StringLength(25)]
        public string CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        [StringLength(25)]
        public string ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool? DeleteFlag { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fpen_amt_old { get; set; }

        [Key]
        public int ID_SBTS { get; set; }

        [Column(TypeName = "image")]
        public byte[] Photo { get; set; }

        [Column(TypeName = "image")]
        public byte[] Fingerprint1 { get; set; }

        [Column(TypeName = "image")]
        public byte[] Fingerprint2 { get; set; }
    }
}
