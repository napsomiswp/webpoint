namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class c_benp
    {
        [StringLength(17)]
        public string fssno { get; set; }

        [StringLength(12)]
        public string fclaim_no { get; set; }

        [StringLength(7)]
        public string fbnk { get; set; }

        [StringLength(14)]
        public string fcheq_no { get; set; }

        [StringLength(20)]
        public string facctno { get; set; }

        [StringLength(3)]
        public string floc { get; set; }

        [StringLength(1)]
        public string fsex { get; set; }

        [StringLength(6)]
        public string fpay_perio { get; set; }

        [StringLength(2)]
        public string ftype { get; set; }

        [StringLength(2)]
        public string fbt_award { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fdeduction { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? farr_deduc { get; set; }

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

        [Column(TypeName = "smalldatetime")]
        public DateTime? fpay_date { get; set; }

        [StringLength(1)]
        public string fmode { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ftimes_run { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? fdate_rec { get; set; }

        [StringLength(6)]
        public string fuser_paid { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ftrn_date { get; set; }

        [StringLength(7)]
        public string fpaypoint { get; set; }

        [StringLength(1)]
        public string frequency { get; set; }

        [StringLength(1)]
        public string fstatus { get; set; }

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
