namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MoneyDependantMaster")]
    public partial class MoneyDependantMaster
    {
        [StringLength(17)]
        public string fssno { get; set; }

        [StringLength(3)]
        public string floc { get; set; }

        [StringLength(17)]
        public string fn_ssno { get; set; }

        [StringLength(12)]
        public string fdclaim_no { get; set; }

        [StringLength(100)]
        public string fn_surname { get; set; }

        [StringLength(100)]
        public string fn_frstnam { get; set; }

        [StringLength(100)]
        public string fn_othname { get; set; }

        [StringLength(200)]
        public string fn_homeadd { get; set; }

        [StringLength(1)]
        public string fn_sex { get; set; }

        [StringLength(1)]
        public string fsch_stat { get; set; }

        public DateTime? fnb_date { get; set; }

        [StringLength(1)]
        public string fdep_type { get; set; }

        [StringLength(1)]
        public string fphy_stat { get; set; }

        [StringLength(1)]
        public string fpen_stat { get; set; }

        [StringLength(1)]
        public string fstatus { get; set; }

        [StringLength(2)]
        public string frelation { get; set; }

        [StringLength(17)]
        public string fbatch_no { get; set; }

        public DateTime? finvest_da { get; set; }

        [StringLength(2)]
        public string finvest { get; set; }

        [StringLength(100)]
        public string fper_addr { get; set; }

        [StringLength(1)]
        public string fappr_code { get; set; }

        [StringLength(100)]
        public string fres_addr { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fshare { get; set; }

        [StringLength(1)]
        public string fpaymode { get; set; }

        [StringLength(7)]
        public string fpaypoint { get; set; }

        [StringLength(1)]
        public string frequency { get; set; }

        [StringLength(7)]
        public string fbnk { get; set; }

        [StringLength(14)]
        public string fcheq_no { get; set; }

        [StringLength(30)]
        public string facctno { get; set; }

        [StringLength(1)]
        public string fmember { get; set; }

        [StringLength(1)]
        public string fjob_stat { get; set; }

        [StringLength(1)]
        public string fvalid { get; set; }

        public DateTime? fpen_end { get; set; }

        public DateTime? fdateupd { get; set; }

        [StringLength(2)]
        public string fpen_type { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fgrant_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ftotal_paid { get; set; }

        [StringLength(6)]
        public string flpay_perd { get; set; }

        [StringLength(2)]
        public string ftype { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? farrears { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ftimes_paid { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fdeduction { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? farr_deduct { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fshare_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fshare_amt_old { get; set; }

        [StringLength(25)]
        public string CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        [StringLength(25)]
        public string ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool? DeleteFlag { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(8)]
        public string CreatedOnShort { get; set; }

        [Key]
        public int ID_SBTS { get; set; }
    }
}
