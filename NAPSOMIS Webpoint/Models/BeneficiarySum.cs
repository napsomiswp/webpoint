namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BeneficiarySum")]
    public partial class BeneficiarySum
    {
        [StringLength(3)]
        public string floc { get; set; }

        [StringLength(25)]
        public string fregion { get; set; }

        [StringLength(6)]
        public string fpay_period { get; set; }

        [StringLength(2)]
        public string fbt_award { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? froll { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? famount { get; set; }

        [StringLength(25)]
        public string CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        [StringLength(25)]
        public string ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool? DeleteFlag { get; set; }

        [Key]
        public int ID_SBTS { get; set; }
    }
}
