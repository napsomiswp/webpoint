namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DependantMaster")]
    public partial class DependantMaster
    {
        [StringLength(17)]
        public string fssno { get; set; }

        [StringLength(3)]
        public string floc { get; set; }

        [StringLength(17)]
        public string fn_ssno { get; set; }

        [StringLength(12)]
        public string fdclaim_no { get; set; }

        [StringLength(25)]
        public string fn_surname { get; set; }

        [StringLength(20)]
        public string fn_frstnam { get; set; }

        [StringLength(20)]
        public string fn_othname { get; set; }

        [StringLength(60)]
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

        public bool? fstatus { get; set; }

        [StringLength(2)]
        public string frelation { get; set; }

        [StringLength(17)]
        public string fbatch_no { get; set; }

        public DateTime? finvest_date { get; set; }

        [StringLength(2)]
        public string finvest { get; set; }

        [StringLength(45)]
        public string fper_addr { get; set; }

        [StringLength(1)]
        public string fappr_code { get; set; }

        [StringLength(45)]
        public string fres_addr { get; set; }

        public decimal? fshare { get; set; }

        [StringLength(1)]
        public string fpay_mode { get; set; }

        [StringLength(7)]
        public string fpaypoint { get; set; }

        [StringLength(1)]
        public string frequency { get; set; }

        [StringLength(7)]
        public string fbnk { get; set; }

        [StringLength(14)]
        public string fcheq_no { get; set; }

        [StringLength(20)]
        public string facctno { get; set; }

        [StringLength(1)]
        public string fmember { get; set; }

        [StringLength(1)]
        public string fapp_stat { get; set; }

        [StringLength(1)]
        public string fjob_stat { get; set; }

        public DateTime? fdateupd { get; set; }

        [Key]
        public int ID_SBTS { get; set; }

        [StringLength(20)]
        public string CREATEDBY { get; set; }

        public DateTime? CREATEDON { get; set; }

        [StringLength(20)]
        public string MODIFIEDBY { get; set; }

        public DateTime? MODIFIEDON { get; set; }
    }
}
