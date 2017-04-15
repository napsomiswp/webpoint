namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NASSITPercentage")]
    public partial class NASSITPercentage
    {
        [Display(Name ="Percentage")]
        [Required] 
        [Key]
        public decimal NPercentage { get; set; }

 
    }
}
