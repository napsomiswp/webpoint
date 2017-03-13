namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AUDIT_LOG_DATA
    {
        [Key]
        public int AUDIT_LOG_DATA_ID { get; set; }

        public int AUDIT_LOG_TRANSACTION_ID { get; set; }

        [Required]
        [StringLength(1500)]
        public string PRIMARY_KEY_DATA { get; set; }

        [Required]
        [StringLength(128)]
        public string COL_NAME { get; set; }

        [Column(TypeName = "ntext")]
        public string OLD_VALUE_LONG { get; set; }

        [Column(TypeName = "ntext")]
        public string NEW_VALUE_LONG { get; set; }

        [Column(TypeName = "image")]
        public byte[] NEW_VALUE_BLOB { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(8000)]
        public string NEW_VALUE { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(8000)]
        public string OLD_VALUE { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Required]
        [StringLength(1500)]
        public string PRIMARY_KEY { get; set; }

        [Required]
        [StringLength(1)]
        public string DATA_TYPE { get; set; }

        [StringLength(500)]
        public string KEY1 { get; set; }

        [StringLength(500)]
        public string KEY2 { get; set; }

        [StringLength(500)]
        public string KEY3 { get; set; }

        [StringLength(500)]
        public string KEY4 { get; set; }
    }
}
