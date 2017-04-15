namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class cpay_tr
    {
        [StringLength(50)]
        public string fssno { get; set; }

        [StringLength(50)]
        public string fclaim_no { get; set; }

        [StringLength(50)]
        public string fdclaim_no { get; set; }

        [StringLength(50)]
        public string fsurname { get; set; }

        [StringLength(50)]
        public string firstname { get; set; }

        [StringLength(50)]
        public string fothname { get; set; }

        [StringLength(50)]
        public string flast_desi { get; set; }

        [StringLength(100)]
        public string fbnk { get; set; }

        [StringLength(50)]
        public string flocation { get; set; }

        [StringLength(50)]
        public string fcheq_no { get; set; }

        [StringLength(50)]
        public string frequency { get; set; }

        [StringLength(50)]
        public string floc { get; set; }

        [StringLength(50)]
        public string fsex { get; set; }

        [StringLength(50)]
        public string fpay_period { get; set; }

        [StringLength(50)]
        public string ftype { get; set; }

        [StringLength(50)]
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

        [StringLength(50)]
        public string fstatus { get; set; }

        [StringLength(50)]
        public string fpay_point { get; set; }

        [StringLength(50)]
        public string fpaypoint { get; set; }

        public DateTime? ftrn_date { get; set; }

        [StringLength(50)]
        public string fuser_paid { get; set; }

        public DateTime? fdate_rec { get; set; }

        [StringLength(25)]
        public string CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        [StringLength(25)]
        public string ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool? DeleteFlag { get; set; }

        [StringLength(1)]
        public string frec_stat { get; set; }

        public bool? ftran_log { get; set; }

        [Key]
        public int ID_SBTS { get; set; }
    }
}
