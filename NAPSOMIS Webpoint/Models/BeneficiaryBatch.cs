namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BeneficiaryBatch")]
    public partial class BeneficiaryBatch
    {
        [StringLength(17)]
        public string fbatch_no { get; set; }

        [StringLength(1)]
        public string fben_type { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fno_rec { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fno_reject { get; set; }

        [StringLength(1)]
        public string fstatus { get; set; }

        public DateTime? fdateupd { get; set; }

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
