namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BeneficiaryTransactionLog")]
    public partial class BeneficiaryTransactionLog
    {
        [StringLength(3)]
        public string floc { get; set; }

        [StringLength(6)]
        public string fperiod { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fclaim_recno { get; set; }

        [StringLength(2)]
        public string fbt_award { get; set; }

        [StringLength(1)]
        public string fapp_status { get; set; }

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
