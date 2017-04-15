namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class c_crsreg
    {
        [StringLength(6)]
        public string fperiod { get; set; }

        [StringLength(6)]
        public string feperiod { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fbaktype { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fnowkr { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ftot_cr { get; set; }

        [StringLength(2)]
        public string fschme { get; set; }

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
