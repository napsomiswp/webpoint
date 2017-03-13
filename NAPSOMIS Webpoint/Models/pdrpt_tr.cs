namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class pdrpt_tr
    {
        [StringLength(17)]
        public string fbatch_no { get; set; }

        [StringLength(3)]
        public string floc { get; set; }

        [StringLength(17)]
        public string fssno { get; set; }

        [StringLength(30)]
        public string fsurname { get; set; }

        [StringLength(20)]
        public string firstname { get; set; }

        [StringLength(20)]
        public string fothname { get; set; }

        [StringLength(1)]
        public string fsex { get; set; }

        [StringLength(1)]
        public string fm_stat { get; set; }

        public DateTime? fb_date { get; set; }

        [StringLength(60)]
        public string fper_addr { get; set; }

        [StringLength(15)]
        public string ftel_no { get; set; }

        [StringLength(1)]
        public string fmst_stat { get; set; }

        [StringLength(45)]
        public string frname { get; set; }

        [StringLength(60)]
        public string fraddress { get; set; }

        [StringLength(15)]
        public string frtelno { get; set; }

        [StringLength(25)]
        public string frelation { get; set; }

        [StringLength(60)]
        public string fdth_cause { get; set; }

        [StringLength(40)]
        public string fdth_place { get; set; }

        public DateTime? fdth_date { get; set; }

        public DateTime? fjoindate { get; set; }

        [StringLength(60)]
        public string fburial_pl { get; set; }

        [StringLength(4)]
        public string fdth_evid { get; set; }

        [StringLength(60)]
        public string fmresd_add { get; set; }

        [StringLength(40)]
        public string fmhome_tow { get; set; }

        [StringLength(11)]
        public string flast_erno { get; set; }

        [StringLength(1)]
        public string fdth_statu { get; set; }

        [StringLength(60)]
        public string freason { get; set; }

        [StringLength(1)]
        public string freject_co { get; set; }

        [StringLength(2)]
        public string finvestiga { get; set; }

        [StringLength(1)]
        public string fstatus { get; set; }

        public DateTime? finvest_da { get; set; }

        [StringLength(1)]
        public string fpen_stat { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fdue_age { get; set; }

        [StringLength(2)]
        public string fbt_award { get; set; }

        public DateTime? fdue_date { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fmths_cr { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? flast_3mths { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fcredit_p { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fadd_mths { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fpen_right { get; set; }

        public DateTime? fterm_date { get; set; }

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
