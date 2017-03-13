namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GeneralCPayTransaction")]
    public partial class GeneralCPayTransaction
    {
        [StringLength(17)]
        public string fssno { get; set; }

        [Required]
        [StringLength(12)]
        public string fclaim_no { get; set; }

        [StringLength(45)]
        public string fsurname { get; set; }

        [StringLength(45)]
        public string firstname { get; set; }

        [StringLength(40)]
        public string fothname { get; set; }

        [StringLength(7)]
        public string fbnk { get; set; }

        [StringLength(150)]
        public string fbnk_name { get; set; }

        [StringLength(20)]
        public string facctno { get; set; }

        [StringLength(30)]
        public string flast_desig { get; set; }

        [StringLength(100)]
        public string faddress { get; set; }

        [StringLength(45)]
        public string flocation { get; set; }

        [StringLength(14)]
        public string fcheq_no { get; set; }

        [StringLength(3)]
        public string floc { get; set; }

        [StringLength(1)]
        public string fsex { get; set; }

        [Required]
        [StringLength(6)]
        public string fpay_period { get; set; }

        [StringLength(2)]
        public string ftype { get; set; }

        [StringLength(2)]
        public string fbt_award { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fdeduction { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? farr_deduct { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? farrears { get; set; }

        [StringLength(6)]
        public string farr_bperd { get; set; }

        [StringLength(6)]
        public string farr_eperd { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? famount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fgrant { get; set; }

        public DateTime? fpay_date { get; set; }

        [StringLength(1)]
        public string fmode { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ftimes_run { get; set; }

        [StringLength(1)]
        public string fstatus { get; set; }

        [StringLength(1)]
        public string ftype_rcpt { get; set; }

        [StringLength(35)]
        public string fpay_point { get; set; }

        [StringLength(1)]
        public string frequency { get; set; }

        [StringLength(6)]
        public string fuser_paid { get; set; }

        public DateTime? ftrn_date { get; set; }

        public DateTime? fdate_rec { get; set; }

        [StringLength(1)]
        public string frec_stat { get; set; }

        [StringLength(25)]
        public string CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        [StringLength(25)]
        public string ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool? DeleteFlag { get; set; }

        [StringLength(7500)]
        public string amt_in_words { get; set; }

        [StringLength(8)]
        public string ModifiedOnShort { get; set; }

        [StringLength(8)]
        public string CreatedOnShort { get; set; }

        [StringLength(1)]
        public string ftran_log { get; set; }

        [Key]
        public int idno { get; set; }
    }
}
