namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BeneficiaryTransactionLogDetail
    {
        [StringLength(3)]
        public string floc { get; set; }

        [StringLength(6)]
        public string fperiod { get; set; }

        [StringLength(6)]
        public string fpayperiod { get; set; }

        [StringLength(2)]
        public string fbt_award { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? frecno { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fgratuityrecno { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fgrantrecno { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? famount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fgratuity { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? farrears { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fgrant { get; set; }

        [StringLength(1)]
        public string fmode { get; set; }

        [StringLength(20)]
        public string Createdby { get; set; }

        public DateTime? Createdon { get; set; }

        [StringLength(20)]
        public string Modifiedby { get; set; }

        public DateTime? Modifiedon { get; set; }

        [Key]
        public int ID_SBTS { get; set; }
    }
}
