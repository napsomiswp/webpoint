namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CReturn")]
    public partial class CReturn
    {
        [StringLength(16)]
        public string ffile { get; set; }

        [StringLength(1)]
        public string ftype { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? frec_no { get; set; }

        [StringLength(18)]
        public string fref_no { get; set; }

        public DateTime? fdate { get; set; }

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
