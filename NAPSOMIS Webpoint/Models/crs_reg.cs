namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class crs_reg
    {
        [StringLength(11)]
        public string ferno { get; set; }

        [StringLength(1)]
        public string ftype { get; set; }

        [StringLength(1)]
        public string fcat { get; set; }

        [StringLength(6)]
        public string fperiod { get; set; }

        [StringLength(1)]
        public string fmode { get; set; }

        [StringLength(1)]
        public string fmedia { get; set; }

        public DateTime? fdate_rec { get; set; }

        public DateTime? fdate_cap { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fnowkr { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fwkr_rec { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ftot_cr { get; set; }

        public DateTime? fdate_data { get; set; }

        [StringLength(3)]
        public string fdata_user { get; set; }

        [StringLength(1)]
        public string fremark { get; set; }

        [StringLength(6)]
        public string feperiod { get; set; }

        [StringLength(1)]
        public string fbaktype { get; set; }

        [StringLength(1)]
        public string fstatus { get; set; }

        [StringLength(10)]
        public string fuser_cap { get; set; }

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
