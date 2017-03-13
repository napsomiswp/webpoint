namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MainLogin")]
    public partial class MainLogin
    {
        [Key]
        [StringLength(15)]
        public string AccountID { get; set; }

        [Required]
        [StringLength(20)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(20)]
        public string MiddleName { get; set; }

        [Required]
        [StringLength(20)]
        public string LastName { get; set; }

        [Required]
        [StringLength(15)]
        public string Gender { get; set; }

        [Required]
        [StringLength(50)]
        public string UserName { get; set; }

        [Required]
        public byte[] UserGroup { get; set; }

        [Required]
        public byte[] Password { get; set; }

        [Required]
        [StringLength(20)]
        public string AccountStatus { get; set; }

        [Required]
        [StringLength(50)]
        public string Branch { get; set; }

        [Required]
        [StringLength(50)]
        public string Department { get; set; }

        [Required]
        public byte[] AccessibleFeatures { get; set; }

        [Required]
        [StringLength(3000)]
        public string AccessibleIndices { get; set; }

        [Column(TypeName = "date")]
        public DateTime RegDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime RenewDate { get; set; }

        [StringLength(500)]
        public string SecurityQuestion { get; set; }

        public byte[] Answer { get; set; }

        public byte[] RecordAccessLevel { get; set; }
    }
}
