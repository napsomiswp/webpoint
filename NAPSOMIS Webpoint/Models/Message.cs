namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Message")]
    public partial class Message
    {
        public int MessageID { get; set; }

        [Required]
        [StringLength(50)]
        public string SenderID { get; set; }

        [Required]
        [StringLength(50)]
        public string ReceipientID { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string MessageBody { get; set; }

        [Required]
        [StringLength(20)]
        public string MessageStatus { get; set; }

        [Required]
        [StringLength(50)]
        public string Urgency { get; set; }

        [Required]
        [StringLength(50)]
        public string MessageSubject { get; set; }

        [Required]
        [StringLength(50)]
        public string SenderName { get; set; }

        [Required]
        [StringLength(50)]
        public string ReceipientName { get; set; }

        [Column(TypeName = "date")]
        public DateTime InputDate { get; set; }

        public byte[] Attachment { get; set; }

        [StringLength(50)]
        public string AttachmentName { get; set; }
    }
}
