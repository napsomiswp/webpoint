namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProgramVersion")]
    public partial class ProgramVersion
    {
        [Key]
        [Column("ProgramVersion")]
        [StringLength(10)]
        public string ProgramVersion1 { get; set; }

        [Column(TypeName = "date")]
        public DateTime ExpiryDate { get; set; }

        [Required]
        [StringLength(50)]
        public string ProgramStatus { get; set; }
    }
}
