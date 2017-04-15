namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class emprg_s
    {
        [StringLength(4)]
        public string fyear { get; set; }

        [StringLength(2)]
        public string fmonth { get; set; }

        [StringLength(3)]
        public string floc { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fprivate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fself_fin { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fsub_full { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? facg_est { get; set; }

        [Column(TypeName = "smalldatetime")]
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
