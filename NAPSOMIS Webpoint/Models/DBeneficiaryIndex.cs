namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DBeneficiaryIndex")]
    public partial class DBeneficiaryIndex
    {
        [StringLength(4)]
        public string fyear { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? findx_rate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? findx_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fbonus_rate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fbonus_amt { get; set; }

        [StringLength(6)]
        public string fbonus_sperd { get; set; }

        [StringLength(6)]
        public string fbonus_eperd { get; set; }

        [StringLength(25)]
        public string CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        [StringLength(25)]
        public string ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool? DeleteFlag { get; set; }

        [Key]
        public int ID_SBTS { get; set; }

        public DateTime? EffectiveDate { get; set; }

        [StringLength(10)]
        public string fbatch_no { get; set; }

        public bool? frunupdate { get; set; }
    }
}
