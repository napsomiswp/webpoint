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
 
        [StringLength(50)]
        public string SenderID { get; set; }
 
        [StringLength(50)]
        public string ReceipientID { get; set; }

        [Column(TypeName = "text")] 
        public string MessageBody { get; set; }
 
        [StringLength(20)]
        public string MessageStatus { get; set; }
 
        [StringLength(50)]
        public string Urgency { get; set; }
 
        [StringLength(50)]
        public string MessageSubject { get; set; }
 
        [StringLength(50)]
        public string SenderName { get; set; }
 
        [StringLength(50)]
        public string ReceipientName { get; set; }

        [Column(TypeName = "date")]
        public DateTime InputDate { get; set; }

        public byte[] Attachment { get; set; }

        [StringLength(50)]
        public string AttachmentName { get; set; }
    }
}
