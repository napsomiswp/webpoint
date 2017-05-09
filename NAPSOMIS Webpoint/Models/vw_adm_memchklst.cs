namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_adm_memchklst
    {
        [Key]
        [StringLength(17)]
        public string fssno { get; set; }

        [StringLength(12)]
        public string fclaim_no { get; set; }

        [StringLength(25)]
        public string fsurname { get; set; }

        [StringLength(20)]
        public string firstname { get; set; }

        [StringLength(20)]
        public string fothname { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? fjoindate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? fbirth_dat { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? fterm_date { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? fapp_date { get; set; }

        [StringLength(7)]
        public string fpaypoint { get; set; }

        [StringLength(60)]
        public string flocation { get; set; }

        [StringLength(25)]
        public string ffsurname { get; set; }

        [StringLength(20)]
        public string ffirstname { get; set; }

        [StringLength(20)]
        public string ffothname { get; set; }

        [StringLength(1)]
        public string fpay_mode { get; set; }

        [StringLength(11)]
        public string flast_erno { get; set; }

        [StringLength(20)]
        public string ftel_no { get; set; }

        [StringLength(1)]
        public string fsex { get; set; }

        [StringLength(7)]
        public string fbank { get; set; }

        [StringLength(15)]
        public string facctno { get; set; }

        [StringLength(60)]
        public string fmresd_addr { get; set; }

        [StringLength(25)]
        public string fpassport_no { get; set; }

        [StringLength(2)]
        public string fben_type { get; set; }

        [StringLength(25)]
        public string fmsurname { get; set; }

        [StringLength(20)]
        public string fmfirstname { get; set; }

        [StringLength(20)]
        public string fmothname { get; set; }

        [StringLength(40)]
        public string fnationality { get; set; }

        [StringLength(40)]
        public string fmhome_town { get; set; }

        [StringLength(1)]
        public string frequency { get; set; }

        [StringLength(30)]
        public string fben_desc { get; set; }

        [StringLength(61)]
        public string fbank_name { get; set; }

        [StringLength(30)]
        public string fpay_pnt { get; set; }

        [StringLength(25)]
        public string freq { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? fdateupd { get; set; }

        [StringLength(256)]
        public string femp_name { get; set; }

        [StringLength(6)]
        public string fapro_by { get; set; }

        [StringLength(25)]
        public string finvest_g { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? finvest_da { get; set; }

        [StringLength(1)]
        public string fmst_status { get; set; }

        [StringLength(1)]
        public string freject_code { get; set; }
    }
}
