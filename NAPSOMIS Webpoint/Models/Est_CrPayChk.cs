namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Est_CrPayChk
    {
        [Key]
        [StringLength(11)]
        public string ferno { get; set; }

        [StringLength(200)]
        public string femp_name { get; set; }

        [StringLength(4)]
        public string floc { get; set; }

        public DateTime? fcov_date { get; set; }

        [StringLength(6)]
        public string fbeginperiod { get; set; }

        [StringLength(6)]
        public string fendperiod { get; set; }

        [StringLength(6)]
        public string fcrlastperiod { get; set; }

        [StringLength(1)]
        public string fcompute { get; set; }

        [StringLength(20)]
        public string Createdby { get; set; }

        public DateTime? Createdon { get; set; }

        [StringLength(20)]
        public string Modifiedby { get; set; }

        public DateTime? Modifiedon { get; set; }
    }
}
