namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BRSTran_Log
    {
        [Key]
        [Column(Order = 0)]
        public int ftran_no { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime ftran_date { get; set; }

        public bool? fverifyStatus { get; set; }

        [StringLength(17)]
        public string fssno { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(12)]
        public string fclaim_no { get; set; }

        [StringLength(100)]
        public string fmachine { get; set; }

        [StringLength(100)]
        public string fIPAddress { get; set; }

        [StringLength(100)]
        public string fformName { get; set; }

        [StringLength(20)]
        public string fusercode { get; set; }

        [StringLength(100)]
        public string fusername { get; set; }

        [StringLength(20)]
        public string Createdby { get; set; }

        public DateTime? Createdon { get; set; }

        [StringLength(20)]
        public string Modifiedby { get; set; }

        public DateTime? Modifiedon { get; set; }

        [StringLength(100)]
        public string freason { get; set; }
    }
}
