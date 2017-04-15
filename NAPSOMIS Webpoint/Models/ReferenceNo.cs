namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReferenceNos")]
    public partial class ReferenceNo
    {
        [Key]
        public int ReferenceID { get; set; }
 
        [StringLength(20)]
        public string Range { get; set; }
 
        [StringLength(50)]
        public string GeneratedRange { get; set; }
 
        [StringLength(10)]
        public string CurrentYear { get; set; }

        [Required(ErrorMessage = "The date value is reqired")]
        [Column(TypeName = "date")]
        public DateTime TodaysDate { get; set; }

        [StringLength(10)]
        public string Centre { get; set; }

        [Required(ErrorMessage ="The quantity to generatate is required")]
        public int QuantityToGenerate { get; set; }
 
        [StringLength(10)]
        public string GeneratedBy { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateGenerated { get; set; }
 
    }
}
