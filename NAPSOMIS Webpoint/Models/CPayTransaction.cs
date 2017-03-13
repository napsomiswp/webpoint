namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CPayTransaction")]
    public partial class CPayTransaction
    {
        [StringLength(17)]
        public string fssno { get; set; }

        [StringLength(12)]
        public string fclaim_no { get; set; }

        [StringLength(3)]
        public string floc { get; set; }

        [StringLength(6)]
        public string fpay_perio { get; set; }

        [StringLength(2)]
        public string ftype { get; set; }

        public DateTime? fdate_rec { get; set; }

        [StringLength(6)]
        public string fuser_paid { get; set; }

        public DateTime? ftrn_date { get; set; }

        [Key]
        public int ID_SBTS { get; set; }

        [StringLength(20)]
        public string CREATEDBY { get; set; }

        public DateTime? CREATEDON { get; set; }

        [StringLength(20)]
        public string MODIFIEDBY { get; set; }

        public DateTime? MODIFIEDON { get; set; }
    }
}
