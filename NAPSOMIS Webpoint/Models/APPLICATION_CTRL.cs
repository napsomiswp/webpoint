namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class APPLICATION_CTRL
    {
        [StringLength(200)]
        public string V_CLIENTNAME { get; set; }

        public DateTime? D_STARTDATE { get; set; }

        public bool? B_ENGLISH { get; set; }

        [StringLength(50)]
        public string V_CAPTION { get; set; }

        [StringLength(100)]
        public string V_FONTNAME { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? N_FONTSIZE { get; set; }

        [Key]
        public int ID_SBTS { get; set; }
    }
}
