namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class cctrl3
    {
        [StringLength(15)]
        public string fdesc { get; set; }

        [StringLength(1)]
        public string ftype { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fno { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? famount { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? frecptdate { get; set; }

        [StringLength(6)]
        public string fuser_code { get; set; }

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
