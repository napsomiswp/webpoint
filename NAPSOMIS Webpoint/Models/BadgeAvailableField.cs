namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BadgeAvailableField
    {
        public Guid ID { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? Modified { get; set; }

        [StringLength(255)]
        public string FieldName { get; set; }

        [StringLength(255)]
        public string DisplayName { get; set; }

        [Key]
        public int ID_SBTS { get; set; }
    }
}
