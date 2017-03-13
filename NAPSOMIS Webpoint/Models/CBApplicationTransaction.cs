namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CBApplicationTransaction")]
    public partial class CBApplicationTransaction
    {
        [StringLength(3)]
        public string FLOC { get; set; }

        [StringLength(17)]
        public string FSSNO { get; set; }

        [StringLength(12)]
        public string FCLAIM_NO { get; set; }

        [StringLength(1)]
        public string FSEX { get; set; }

        [StringLength(1)]
        public string FREJECT_CO { get; set; }

        [StringLength(11)]
        public string FLAST_ERNO { get; set; }

        [StringLength(100)]
        public string FSURNAME { get; set; }

        [StringLength(100)]
        public string FIRSTNAME { get; set; }

        [StringLength(100)]
        public string FOTHNAME { get; set; }

        public DateTime? FTERM_DATE { get; set; }

        [StringLength(7)]
        public string FBANK { get; set; }

        [StringLength(20)]
        public string FACCTNO { get; set; }

        [StringLength(1)]
        public string FPAY_MODE { get; set; }

        [StringLength(500)]
        public string FMRESD_ADD { get; set; }

        [StringLength(25)]
        public string FPASSPORT_ { get; set; }

        [StringLength(2)]
        public string FBEN_TYPE { get; set; }

        public DateTime? FJOINDATE { get; set; }

        public DateTime? FBIRTH_DAT { get; set; }

        [StringLength(100)]
        public string FFSURNAME { get; set; }

        [StringLength(100)]
        public string FFIRSTNAME { get; set; }

        [StringLength(100)]
        public string FFOTHNAME { get; set; }

        [StringLength(100)]
        public string FMSURNAME { get; set; }

        [StringLength(100)]
        public string FMFIRSTNAM { get; set; }

        [StringLength(100)]
        public string FMOTHNAME { get; set; }

        public DateTime? FAPP_DATE { get; set; }

        [StringLength(80)]
        public string FNATIONALI { get; set; }

        [StringLength(60)]
        public string FLOCATION { get; set; }

        [StringLength(20)]
        public string FTEL_NO { get; set; }

        [StringLength(120)]
        public string FMHOME_TOW { get; set; }

        [StringLength(6)]
        public string FINVESTIGA { get; set; }

        public DateTime? FINVEST_DA { get; set; }

        [StringLength(1)]
        public string FAPPR_CODE { get; set; }

        [StringLength(6)]
        public string FAPPR_BY { get; set; }

        public DateTime? FDATEUPD { get; set; }

        [StringLength(6)]
        public string FPBEN_BPER { get; set; }

        [StringLength(6)]
        public string FPBEN_EPER { get; set; }

        [StringLength(1)]
        public string FEMP_TYPE { get; set; }

        [StringLength(1)]
        public string FE_STAT { get; set; }

        public DateTime? FE_BDATE { get; set; }

        public DateTime? FE_EDATE { get; set; }

        [StringLength(40)]
        public string FE_DESC { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FP_AMT { get; set; }

        [StringLength(3)]
        public string FP_DIST { get; set; }

        [StringLength(11)]
        public string FP_ERNO { get; set; }

        [StringLength(1)]
        public string FMST_STATU { get; set; }

        [StringLength(7)]
        public string FPAYPOINT { get; set; }

        [StringLength(1)]
        public string FREQUENCY { get; set; }

        [StringLength(6)]
        public string FUSER_CODE { get; set; }

        [StringLength(17)]
        public string FBATCH_NO { get; set; }

        [StringLength(25)]
        public string CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        [StringLength(25)]
        public string ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool? DeleteFlag { get; set; }

        [StringLength(50)]
        public string src_contr { get; set; }

        [Key]
        public int ID_SBTS { get; set; }
    }
}
