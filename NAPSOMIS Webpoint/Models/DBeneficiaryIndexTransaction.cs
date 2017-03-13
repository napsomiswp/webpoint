namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DBeneficiaryIndexTransaction")]
    public partial class DBeneficiaryIndexTransaction
    {
        [StringLength(4)]
        public string fyear { get; set; }

        public DateTime? fdate_run { get; set; }

        [StringLength(25)]
        public string CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        [StringLength(25)]
        public string ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool? DeleteFlag { get; set; }

        [Key]
        public int ID_SBTS { get; set; }

        [StringLength(10)]
        public string fbatch_no { get; set; }

        public bool? frunupdate { get; set; }
    }
}
