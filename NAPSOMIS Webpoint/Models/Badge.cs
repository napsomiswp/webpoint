namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Badge")]
    public partial class Badge
    {
        public Guid ID { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? Modified { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [Column(TypeName = "ntext")]
        public string BadgeData { get; set; }

        public bool? Completed { get; set; }

        [Key]
        public int ID_SBTS { get; set; }
    }
}
