namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GovtMapSSNO")]
    public partial class GovtMapSSNO
    {
        [Key]
        public int SBTS_ID { get; set; }

        [Required]
        [StringLength(11)]
        public string fclaim_no { get; set; }

        [Required]
        [StringLength(17)]
        public string fGovtPenSSNo { get; set; }

        [Required]
        [StringLength(17)]
        public string fDepSSNo { get; set; }

        [Required]
        [StringLength(2)]
        public string fDep_Type { get; set; }

        public bool fstatus { get; set; }

        public bool? ftran_log { get; set; }

        [StringLength(10)]
        public string CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        [StringLength(10)]
        public string ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }
    }
}
