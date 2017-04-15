namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class hist_tmp
    {
        [StringLength(11)]
        public string ferno { get; set; }

        [StringLength(1)]
        public string fcat { get; set; }

        public int? ftotwkr { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ftotcr { get; set; }

        public int? fwkrs { get; set; }

        [StringLength(1)]
        public string fmode { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fcont { get; set; }

        [StringLength(17)]
        public string fno { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fno1 { get; set; }

        [StringLength(15)]
        public string fstaffno { get; set; }

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
