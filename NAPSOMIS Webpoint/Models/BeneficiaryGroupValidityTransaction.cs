namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BeneficiaryGroupValidityTransaction")]
    public partial class BeneficiaryGroupValidityTransaction
    {
        [StringLength(255)]
        public string fgov_code { get; set; }

        [StringLength(255)]
        public string fgov_desc { get; set; }

        [StringLength(255)]
        public string fssno { get; set; }

        public DateTime? fjoindate { get; set; }

        public double? fcr_mths { get; set; }

        public double? fcr_award { get; set; }

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
