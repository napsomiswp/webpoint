namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class bnaprj_tr
    {
        [StringLength(17)]
        public string fssno { get; set; }

        [StringLength(12)]
        public string fclaim_no { get; set; }

        [StringLength(1)]
        public string fsex { get; set; }

        [StringLength(11)]
        public string flast_erno { get; set; }

        [StringLength(25)]
        public string fsurname { get; set; }

        [StringLength(20)]
        public string firstname { get; set; }

        [StringLength(20)]
        public string fothname { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? fterm_date { get; set; }

        [StringLength(7)]
        public string fbank { get; set; }

        [StringLength(15)]
        public string facctno { get; set; }

        [StringLength(1)]
        public string fpay_mode { get; set; }

        [StringLength(60)]
        public string fmresd_addr { get; set; }

        [StringLength(25)]
        public string fpassport_no { get; set; }

        [StringLength(2)]
        public string fben_type { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? fjoindate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? fbirth_date { get; set; }

        [StringLength(25)]
        public string ffsurname { get; set; }

        [StringLength(20)]
        public string ffirstname { get; set; }

        [StringLength(20)]
        public string ffothname { get; set; }

        [StringLength(25)]
        public string fmsurname { get; set; }

        [StringLength(20)]
        public string fmfirstname { get; set; }

        [StringLength(20)]
        public string fmothname { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? fapp_date { get; set; }

        [StringLength(40)]
        public string fnationality { get; set; }

        [StringLength(60)]
        public string flocation { get; set; }

        [StringLength(20)]
        public string ftel_no { get; set; }

        [StringLength(1)]
        public string freject_code { get; set; }

        [StringLength(40)]
        public string fmhome_town { get; set; }

        [StringLength(6)]
        public string finvestigator { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? finvest_date { get; set; }

        [StringLength(1)]
        public string fappr_code { get; set; }

        [StringLength(6)]
        public string fappr_by { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? fdateupd { get; set; }

        [StringLength(11)]
        public string fp_erno { get; set; }

        [StringLength(1)]
        public string fmst_status { get; set; }

        [StringLength(7)]
        public string fpaypoint { get; set; }

        [StringLength(1)]
        public string frequency { get; set; }

        [StringLength(6)]
        public string fuser_code { get; set; }

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
