namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("cdpenper")]
    public partial class cdpenper
    {
        public decimal? fcnt { get; set; }

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

        [StringLength(500)]
        public string fn_homeadd { get; set; }

        [StringLength(1)]
        public string fn_sex { get; set; }

        [StringLength(1)]
        public string fsch_stat { get; set; }

        public DateTime? fnb_date { get; set; }

        [StringLength(2)]
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

        [StringLength(500)]
        public string fper_addr { get; set; }

        [StringLength(1)]
        public string fappr_code { get; set; }

        [StringLength(500)]
        public string fres_addr { get; set; }

        [StringLength(7)]
        public string fbnk { get; set; }

        [StringLength(14)]
        public string fcheq_no { get; set; }

        [StringLength(20)]
        public string facctno { get; set; }

        [StringLength(40)]
        public string frel_desc { get; set; }

        [StringLength(40)]
        public string fdtype_des { get; set; }

        [StringLength(1)]
        public string fmember { get; set; }

        [StringLength(1)]
        public string fjob_stat { get; set; }

        [StringLength(1)]
        public string fvalid { get; set; }

        public DateTime? fpen_end { get; set; }

        [StringLength(2)]
        public string fpen_type { get; set; }

        public DateTime? fdateupd { get; set; }

        [StringLength(10)]
        public string ModifiedBy { get; set; }

        public DateTime? Modifiedon { get; set; }

        [StringLength(10)]
        public string createdby { get; set; }

        public DateTime? createdon { get; set; }

        [Key]
        public int ID_SBTS { get; set; }
    }
}
