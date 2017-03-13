namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GeneralBeneficiaryArrangement")]
    public partial class GeneralBeneficiaryArrangement
    {
        [StringLength(12)]
        public string fclaim_no { get; set; }

        public decimal? famount { get; set; }

        [StringLength(6)]
        public string fb_perd { get; set; }

        [StringLength(6)]
        public string fe_perd { get; set; }

        [StringLength(6)]
        public string fpaid_perd { get; set; }

        [StringLength(17)]
        public string fssno { get; set; }

        [StringLength(25)]
        public string createdby { get; set; }

        public DateTime? createdon { get; set; }

        [StringLength(25)]
        public string modifiedby { get; set; }

        public DateTime? modifiedon { get; set; }

        public bool? fstatus { get; set; }

        [Key]
        public int ID_SBTS { get; set; }
    }
}
