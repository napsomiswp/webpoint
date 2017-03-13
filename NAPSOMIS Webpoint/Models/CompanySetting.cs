namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CompanySetting
    {
        [Key]
        [StringLength(10)]
        public string CompanyID { get; set; }

        [Required]
        [StringLength(50)]
        public string NameofCompany { get; set; }

        [Required]
        [StringLength(50)]
        public string Address { get; set; }

        [Required]
        [StringLength(50)]
        public string PhoneNo { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [Column(TypeName = "image")]
        [Required]
        public byte[] Logo { get; set; }
    }
}
