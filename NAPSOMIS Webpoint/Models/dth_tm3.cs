namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class dth_tm3
    {
        [StringLength(19)]
        public string fref_no { get; set; }

        [StringLength(17)]
        public string fssno { get; set; }

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

        [StringLength(45)]
        public string fper_addr { get; set; }

        [StringLength(45)]
        public string fres_addr { get; set; }

        [StringLength(17)]
        public string fbatch_no { get; set; }

        [StringLength(2)]
        public string finvest { get; set; }

        public DateTime? finvest_da { get; set; }

        [StringLength(1)]
        public string fappr_code { get; set; }

        [StringLength(1)]
        public string frej_reaso { get; set; }

        [StringLength(6)]
        public string fuser_code { get; set; }

        [StringLength(20)]
        public string frel_mst { get; set; }

        [StringLength(1)]
        public string fpay_mode { get; set; }

        [StringLength(3)]
        public string floc { get; set; }

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

        public DateTime? fdate_rel { get; set; }

        [StringLength(1)]
        public string fjob_stat { get; set; }

        public DateTime? fdateupd { get; set; }

        [StringLength(40)]
        public string finvest_g { get; set; }

        [StringLength(40)]
        public string fname { get; set; }

        [StringLength(40)]
        public string frel_desc { get; set; }

        [StringLength(40)]
        public string fdtyp_des { get; set; }

        [StringLength(25)]
        public string CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        [StringLength(25)]
        public string ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool? DeleteFlag { get; set; }

        [StringLength(40)]
        public string fevidence { get; set; }

        [StringLength(256)]
        public string femp_name { get; set; }

        [StringLength(20)]
        public string fmarital { get; set; }

        [StringLength(4)]
        public string fdth_evid { get; set; }

        [StringLength(11)]
        public string flast_erno { get; set; }

        [StringLength(1)]
        public string fm_stat { get; set; }

        [Key]
        public int ID_SBTS { get; set; }
    }
}
