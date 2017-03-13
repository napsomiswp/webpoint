namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PensionLog")]
    public partial class PensionLog
    {
        [Key]
        public int ID_SBTS { get; set; }

        [Required]
        [StringLength(17)]
        public string fssno { get; set; }

        [Required]
        [StringLength(12)]
        public string fclaim_no { get; set; }

        public DateTime? fupdate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? foldPenAmt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fnewPenAmt { get; set; }

        [Required]
        [StringLength(10)]
        public string CreatedBy { get; set; }

        public DateTime CreatedOn { get; set; }

        [StringLength(10)]
        public string ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [StringLength(10)]
        public string fbatch_no { get; set; }

        public bool? frunupdate { get; set; }

        [StringLength(4)]
        public string fyear { get; set; }
    }
}
