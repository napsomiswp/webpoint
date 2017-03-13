namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class cmem_stmt
    {
        [StringLength(255)]
        public string fssno { get; set; }

        [StringLength(255)]
        public string fyear { get; set; }

        [StringLength(255)]
        public string fnomths { get; set; }

        [StringLength(255)]
        public string ftot_cr { get; set; }

        [StringLength(255)]
        public string ftot_sal { get; set; }

        [StringLength(255)]
        public string femp { get; set; }

        [StringLength(255)]
        public string fname { get; set; }

        [StringLength(255)]
        public string fsex { get; set; }

        [StringLength(255)]
        public string fjoindate { get; set; }

        [StringLength(255)]
        public string fb_date { get; set; }

        [Key]
        public int ID_SBTS { get; set; }

        [StringLength(20)]
        public string CREATEDBY { get; set; }

        public DateTime? CREATEDON { get; set; }

        [StringLength(20)]
        public string MODIFIEDBY { get; set; }

        public DateTime? MODIFIEDON { get; set; }

        [StringLength(11)]
        public string ferno { get; set; }
    }
}
