namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ProgramUpdate
    {
        [Key]
        [StringLength(10)]
        public string Version { get; set; }

        [Required]
        public byte[] UpdateFile { get; set; }

        [Required]
        [StringLength(50)]
        public string FileName { get; set; }

        [Required]
        [StringLength(20)]
        public string UpdatePriority { get; set; }

        [Required]
        [StringLength(200)]
        public string Description { get; set; }

        [Column(TypeName = "date")]
        public DateTime RegDate { get; set; }

        [Required]
        [StringLength(50)]
        public string InputtedBy { get; set; }
    }
}
