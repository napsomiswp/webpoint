namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OperationEnvironment")]
    public partial class OperationEnvironment
    {
        [Key]
        [StringLength(3)]
        public string fdist_code { get; set; }

        [StringLength(50)]
        public string fdist_loc { get; set; }

        [StringLength(100)]
        public string fdist_mgr { get; set; }

        [StringLength(200)]
        public string fdist_alise { get; set; }

        [StringLength(200)]
        public string fdist_addr { get; set; }

        [StringLength(50)]
        public string fdist_telno { get; set; }

        [StringLength(50)]
        public string fdist_fax { get; set; }

        [StringLength(100)]
        public string fdist_email { get; set; }

        [StringLength(100)]
        public string fdist_dmd { get; set; }

        public decimal? fdist_lc { get; set; }

        [StringLength(50)]
        public string fdist_title { get; set; }

        [StringLength(10)]
        public string createdby { get; set; }

        public DateTime? createdon { get; set; }

        [StringLength(10)]
        public string modifiedby { get; set; }

        public DateTime? modifiedon { get; set; }

        [StringLength(50)]
        public string fservername { get; set; }

        [StringLength(100)]
        public string fpath { get; set; }

        [StringLength(50)]
        public string fdatabasename { get; set; }

        [StringLength(100)]
        public string fBRSDBName { get; set; }
    }
}
