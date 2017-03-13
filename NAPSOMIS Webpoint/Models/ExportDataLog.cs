namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ExportDataLog")]
    public partial class ExportDataLog
    {
        [StringLength(100)]
        public string ftablename { get; set; }

        [StringLength(20)]
        public string fuserName { get; set; }

        [StringLength(20)]
        public string Createdby { get; set; }

        public DateTime? Createdon { get; set; }

        [Key]
        public int idno { get; set; }
    }
}
