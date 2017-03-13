namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SumClaimLocProc")]
    public partial class SumClaimLocProc
    {
        [StringLength(50)]
        public string keydesc { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? keycount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? keyvalue { get; set; }

        [StringLength(4)]
        public string keyloc { get; set; }

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
