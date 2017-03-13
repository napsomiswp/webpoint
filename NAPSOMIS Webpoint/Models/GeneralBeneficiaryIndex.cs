namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GeneralBeneficiaryIndex")]
    public partial class GeneralBeneficiaryIndex
    {
        [StringLength(20)]
        [Display(Name ="Year")]
        public string fyear { get; set; }

        [Display(Name ="Index Rate")]
        public double? findx_rate { get; set; }

        public double? findx_amt { get; set; }

        public double? fbonus_rate { get; set; }

        public double? fbonus_amt { get; set; }

        [StringLength(6)]
        public string fbonus_sperd { get; set; }

        [StringLength(6)]
        public string fbonus_eperd { get; set; }

        [StringLength(25)]
        public string createdby { get; set; }

        public DateTime? createdon { get; set; }

        [StringLength(25)]
        public string modifiedby { get; set; }

        public DateTime? modifiedon { get; set; }

        [Key]
        public int ID_SBTS { get; set; }
    }
}
