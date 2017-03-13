namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PensioPerson")]
    public partial class PensioPerson
    {
        [StringLength(3)]
        public string floc { get; set; }

        [StringLength(17)]
        public string fbatch_no { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(17)]
        public string fssno { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(12)]
        public string fclaim_no { get; set; }

        [StringLength(1)]
        public string fsex { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fdue_age { get; set; }

        [StringLength(1)]
        public string freject_co { get; set; }

        [StringLength(11)]
        public string flast_erno { get; set; }

        [StringLength(100)]
        public string fsurname { get; set; }

        [StringLength(100)]
        public string firstname { get; set; }

        [StringLength(100)]
        public string fothname { get; set; }

        public DateTime? fterm_date { get; set; }

        [StringLength(14)]
        public string fbank { get; set; }

        [StringLength(30)]
        public string facctno { get; set; }

        [StringLength(1)]
        public string fpay_mode { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? flast_3mth { get; set; }

        [StringLength(200)]
        public string fmresd_add { get; set; }

        [StringLength(100)]
        public string fpassport_ { get; set; }

        [StringLength(2)]
        public string fbt_award { get; set; }

        [StringLength(2)]
        public string fben_type { get; set; }

        public DateTime? fjoindate { get; set; }

        public DateTime? fbirth_dat { get; set; }

        [StringLength(100)]
        public string ffsurname { get; set; }

        [StringLength(100)]
        public string ffirstname { get; set; }

        [StringLength(100)]
        public string ffothname { get; set; }

        [StringLength(100)]
        public string fmsurname { get; set; }

        [StringLength(100)]
        public string fmfirstnam { get; set; }

        [StringLength(100)]
        public string fmothname { get; set; }

        public DateTime? fapp_date { get; set; }

        [StringLength(100)]
        public string fnationali { get; set; }

        [StringLength(100)]
        public string flocation { get; set; }

        [StringLength(20)]
        public string ftel_no { get; set; }

        [StringLength(100)]
        public string fmhome_tow { get; set; }

        [StringLength(6)]
        public string finvestiga { get; set; }

        public DateTime? finvest_da { get; set; }

        [StringLength(1)]
        public string fappr_code { get; set; }

        [StringLength(6)]
        public string fappr_by { get; set; }

        public DateTime? fdateupd { get; set; }

        [StringLength(1)]
        public string fmst_statu { get; set; }

        [StringLength(6)]
        public string fuser_code { get; set; }

        [StringLength(25)]
        public string CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        [StringLength(25)]
        public string ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool? DeleteFlag { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_SBTS { get; set; }
    }
}
