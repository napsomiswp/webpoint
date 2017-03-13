namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DeathMaster")]
    public partial class DeathMaster
    {
        [StringLength(17)]
        public string fbatch_no { get; set; }

        [StringLength(12)]
        public string fref_no { get; set; }

        [StringLength(17)]
        public string fssno { get; set; }

        [StringLength(25)]
        public string fsurname { get; set; }

        [StringLength(20)]
        public string firstname { get; set; }

        [StringLength(20)]
        public string fothname { get; set; }

        [StringLength(60)]
        public string fper_addr { get; set; }

        [StringLength(60)]
        public string fcur_addr { get; set; }

        [StringLength(1)]
        public string fm_stat { get; set; }

        [StringLength(30)]
        public string fnation { get; set; }

        [StringLength(40)]
        public string fb_country { get; set; }

        [StringLength(1)]
        public string fsex { get; set; }

        [StringLength(1)]
        public string fprovince { get; set; }

        [StringLength(2)]
        public string fdist { get; set; }

        [StringLength(2)]
        public string fchief { get; set; }

        [StringLength(40)]
        public string ftown { get; set; }

        public DateTime? fb_date { get; set; }

        public DateTime? fjoindate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fincome { get; set; }

        [StringLength(1)]
        public string fnat_incom { get; set; }

        [StringLength(6)]
        public string foccupatio { get; set; }

        [StringLength(256)]
        public string femp_name { get; set; }

        [StringLength(11)]
        public string ferno { get; set; }

        [StringLength(60)]
        public string femp_addr { get; set; }

        [StringLength(15)]
        public string ftel_no { get; set; }

        [StringLength(3)]
        public string floc { get; set; }

        [StringLength(1)]
        public string fquery { get; set; }

        public DateTime? freg_date { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fcr_mths { get; set; }

        [StringLength(2)]
        public string fbt_award { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fdue_age { get; set; }

        public DateTime? fdue_date { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fadd_mths { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? flast_3mths { get; set; }

        public DateTime? fterm_date { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fpen_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fbest_1amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fbest_1mth { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fb5_sal { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fb5_avg { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fgrant { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fdeduction { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fcredit_p { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fpen_right { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fmths_cr { get; set; }

        public DateTime? fgen_date { get; set; }

        [StringLength(1)]
        public string fpen_stat { get; set; }

        [StringLength(1)]
        public string fvalid { get; set; }

        public DateTime? fdateupd { get; set; }

        [StringLength(1)]
        public string fstatus { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fpen_amt_old { get; set; }

        [StringLength(25)]
        public string CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        [StringLength(25)]
        public string ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool? DeleteFlag { get; set; }

        [StringLength(1)]
        public string ftran_log { get; set; }

        [Key]
        public int ID_SBTS { get; set; }
    }
}
