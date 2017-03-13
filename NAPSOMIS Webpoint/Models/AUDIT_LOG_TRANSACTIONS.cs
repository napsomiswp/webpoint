namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AUDIT_LOG_TRANSACTIONS
    {
        [Key]
        public int AUDIT_LOG_TRANSACTION_ID { get; set; }

        [Required]
        [StringLength(128)]
        public string DATABASE { get; set; }

        [Required]
        [StringLength(261)]
        public string TABLE_NAME { get; set; }

        [Required]
        [StringLength(261)]
        public string TABLE_SCHEMA { get; set; }

        public byte AUDIT_ACTION_ID { get; set; }

        [Required]
        [StringLength(128)]
        public string HOST_NAME { get; set; }

        [Required]
        [StringLength(128)]
        public string APP_NAME { get; set; }

        [Required]
        [StringLength(128)]
        public string MODIFIED_BY { get; set; }

        public DateTime MODIFIED_DATE { get; set; }

        public int AFFECTED_ROWS { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int? SYSOBJ_ID { get; set; }
    }
}
