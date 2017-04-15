namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InsptIntProcess")]
    public partial class InsptIntProcess
    {
        [StringLength(11)]
        public string ferno { get; set; }

        [StringLength(6)]
        public string fperiod { get; set; }

        [StringLength(6)]
        public string fprev_period { get; set; }

        public int? fnostaff { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fTBRate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fIntRate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fPIntRate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fCrAmt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fprev_CrAmt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fIntDays { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fIntAmt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fOutStandAmt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fDelayOutstand { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fIntonOutStand { get; set; }

        public DateTime? fpaymt_date { get; set; }

        [StringLength(20)]
        public string frecptno { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fPayAmt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fpenBalAmt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fPenDays { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fPenIntAmt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fcur_cramt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fCrForward { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fsubtotal { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fbalance { get; set; }

        public DateTime? fpen_date { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Cur_Pay { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Cur_Contr { get; set; }

        [StringLength(25)]
        public string CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        [StringLength(25)]
        public string ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [Key]
        public int ID_SBTS { get; set; }
    }
}
