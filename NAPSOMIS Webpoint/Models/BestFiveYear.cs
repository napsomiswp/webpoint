namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BestFiveYear
    {
        [StringLength(6)]
        public string fyear { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? famount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fno_mths { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? favg_amt { get; set; }

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
