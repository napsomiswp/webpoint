namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class bk_log
    {
        public DateTime? frecptdate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fcash { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fcheq { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fadvice { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fjournal { get; set; }

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
