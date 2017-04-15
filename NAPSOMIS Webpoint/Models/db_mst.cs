namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class db_mst
    {
        [StringLength(3)]
        public string fcode { get; set; }

        [StringLength(100)]
        public string dbservername { get; set; }

        [StringLength(100)]
        public string dbname { get; set; }

        [StringLength(100)]
        public string dbuser { get; set; }

        [StringLength(100)]
        public string pwd { get; set; }

        public DateTime? createdon { get; set; }

        [StringLength(1)]
        public string flag { get; set; }

        [Key]
        public int ID_SBTS { get; set; }

        [StringLength(20)]
        public string CREATEDBY { get; set; }

        [StringLength(20)]
        public string MODIFIEDBY { get; set; }

        public DateTime? MODIFIEDON { get; set; }
    }
}
