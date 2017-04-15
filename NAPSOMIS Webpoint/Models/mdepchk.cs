namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("mdepchk")]
    public partial class mdepchk
    {
        [StringLength(19)]
        public string fref_no { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fcnt { get; set; }

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

        [StringLength(45)]
        public string fname { get; set; }

        [StringLength(45)]
        public string finvest_g { get; set; }

        [StringLength(35)]
        public string fdtype_des { get; set; }

        [StringLength(35)]
        public string frel_desc { get; set; }

        [StringLength(6)]
        public string fuser_code { get; set; }

        [StringLength(1)]
        public string fpay_mode { get; set; }

        [StringLength(40)]
        public string fappro_by { get; set; }

        [StringLength(100)]
        public string fbank_name { get; set; }

        [StringLength(40)]
        public string fdtyp_des { get; set; }

        [StringLength(30)]
        public string fphy_desc { get; set; }

        [StringLength(40)]
        public string floc_desc { get; set; }

        [StringLength(40)]
        public string fpay_pnt { get; set; }

        [StringLength(30)]
        public string freq { get; set; }

        [StringLength(40)]
        public string fsch_name { get; set; }

        [StringLength(30)]
        public string fsch_level { get; set; }

        public DateTime? fstart_dat { get; set; }

        public DateTime? fcomp_date { get; set; }

        [StringLength(1)]
        public string fjob_stat { get; set; }

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
