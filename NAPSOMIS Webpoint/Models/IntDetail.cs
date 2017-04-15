namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class IntDetail
    {
        [StringLength(6)]
        public string Period { get; set; }

        [StringLength(1024)]
        public string Description { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Contribution { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Interest { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Payment { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Balance { get; set; }

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
