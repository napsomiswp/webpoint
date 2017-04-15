namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class pdrpt_tr
    {
        [Key]
        [StringLength(17)]
        public string fssno { get; set; }

        [StringLength(100)]
        public string fsurname { get; set; }

        [StringLength(100)]
        public string firstname { get; set; }

        [StringLength(100)]
        public string fothname { get; set; }

        [StringLength(1)]
        public string fsex { get; set; }

        [StringLength(1)]
        public string fm_stat { get; set; }

        public DateTime? fb_date { get; set; }

        [StringLength(500)]
        public string fper_addr { get; set; }

        [StringLength(15)]
        public string ftel_no { get; set; }

        [StringLength(1)]
        public string fmst_stat { get; set; }

        [StringLength(100)]
        public string frname { get; set; }

        [StringLength(500)]
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
        public string fburial_place { get; set; }

        [StringLength(4)]
        public string fdth_evid { get; set; }

        [StringLength(500)]
        public string fmresd_addr { get; set; }

        [StringLength(40)]
        public string fmhome_town { get; set; }

        [StringLength(11)]
        public string flast_erno { get; set; }

        [StringLength(1)]
        public string fdth_status { get; set; }

        [StringLength(200)]
        public string freason { get; set; }

        [StringLength(2)]
        public string finvestigator { get; set; }

        public DateTime? finvest_date { get; set; }

        public DateTime? fdateupd { get; set; }

        [StringLength(25)]
        public string CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        [StringLength(25)]
        public string ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool? DeleteFlag { get; set; }

        public bool? ftran_log { get; set; }

        [StringLength(12)]
        public string fsclaim_no { get; set; }
    }
}
