namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ben_batch
    {
        [StringLength(255)]
        public string fbatch_no { get; set; }

        [StringLength(255)]
        public string fben_type { get; set; }

        public double? fno_rec { get; set; }

        public double? fno_reject { get; set; }

        [StringLength(255)]
        public string fstatus { get; set; }

        public DateTime? fdateupd { get; set; }

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
