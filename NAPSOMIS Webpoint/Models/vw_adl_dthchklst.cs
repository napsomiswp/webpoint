namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_adl_dthchklst
    {
        [Key]
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

        [Column(TypeName = "smalldatetime")]
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

        [Column(TypeName = "smalldatetime")]
        public DateTime? fdth_date { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? fjoindate { get; set; }

        [StringLength(4)]
        public string fdth_evid { get; set; }

        [StringLength(11)]
        public string flast_erno { get; set; }

        [StringLength(60)]
        public string freason { get; set; }

        [StringLength(60)]
        public string fburial_pl { get; set; }

        [StringLength(60)]
        public string fmresd_add { get; set; }

        [StringLength(40)]
        public string fmhome_tow { get; set; }

        [StringLength(1)]
        public string fdth_statu { get; set; }

        [StringLength(2)]
        public string finvestiga { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? finvest_da { get; set; }

        [StringLength(25)]
        public string finvest_g { get; set; }

        [StringLength(40)]
        public string fevidence { get; set; }

        [StringLength(256)]
        public string femp_name { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? fdateupd { get; set; }

        [StringLength(1)]
        public string fmarital { get; set; }

        [StringLength(1)]
        public string fdth_status { get; set; }
    }
}
