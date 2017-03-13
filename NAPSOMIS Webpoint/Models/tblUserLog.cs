namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblUserLog")]
    public partial class tblUserLog
    {
        [Key]
        public int LogID { get; set; }

        [StringLength(50)]
        public string UserID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? LogDate { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(100)]
        public string FullName { get; set; }

        [StringLength(200)]
        public string Activity { get; set; }

        public decimal? Amount { get; set; }

        [StringLength(50)]
        public string ActivityTime { get; set; }
    }
}
