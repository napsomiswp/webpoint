namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class cmem_dstmt
    {
        [StringLength(17)]
        public string fssno { get; set; }

        [StringLength(500)]
        public string fname { get; set; }

        [StringLength(4)]
        public string fyear { get; set; }

        [StringLength(20)]
        public string fmth { get; set; }

        [StringLength(6)]
        public string fperiod { get; set; }

        [StringLength(50)]
        public string fnomths { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ftot_cr { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fbak_cr { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ftot_sal { get; set; }

        [StringLength(11)]
        public string ferno { get; set; }

        [StringLength(255)]
        public string femp_name { get; set; }

        [StringLength(10)]
        public string fsex { get; set; }

        public DateTime? fjoindate { get; set; }

        public DateTime? fb_date { get; set; }

        [StringLength(255)]
        public string ftown { get; set; }

        [StringLength(17)]
        public string fstaffno { get; set; }

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
