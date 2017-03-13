namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DigitalArchieve")]
    public partial class DigitalArchieve
    {
        [Key]
        [StringLength(10)]
        public string ArchieveID { get; set; }

        [Required]
        [StringLength(50)]
        public string Subject { get; set; }

        [Required]
        [StringLength(50)]
        public string TypeOfAttachment { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [Required]
        [StringLength(100)]
        public string DetailsOfDocument { get; set; }

        [Required]
        [StringLength(50)]
        public string SearchKeyword { get; set; }

        [Required]
        [StringLength(50)]
        public string TheFileName { get; set; }

        [Required]
        public byte[] AttachmentFile { get; set; }

        [Required]
        [StringLength(50)]
        public string SharedAccessLevel { get; set; }

        [Column(TypeName = "date")]
        public DateTime RegDate { get; set; }

        [Required]
        [StringLength(50)]
        public string InputtedBy { get; set; }
    }
}
