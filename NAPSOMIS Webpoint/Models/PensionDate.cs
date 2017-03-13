namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PensionDate")]
    public partial class PensionDate
    {
        [StringLength(2)]
        public string ftype { get; set; }

        [StringLength(6)]
        public string fpay_period { get; set; }

        public DateTime? frun_date { get; set; }

        [StringLength(2)]
        public string ftimes_run { get; set; }

        [StringLength(25)]
        public string ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public DateTime? CreatedOn { get; set; }

        public bool? DeleteFlag { get; set; }

        [StringLength(25)]
        public string CreatedBy { get; set; }

        [Key]
        public int ID_SBTS { get; set; }
    }
}
