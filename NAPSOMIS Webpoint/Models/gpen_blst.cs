namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class gpen_blst
    {
        [StringLength(13)]
        public string fssno { get; set; }

        [StringLength(11)]
        public string fclaim_no { get; set; }

        [StringLength(65)]
        public string fname { get; set; }

        [StringLength(40)]
        public string fbank { get; set; }

        [StringLength(20)]
        public string facctno { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? famount { get; set; }

        [StringLength(30)]
        public string ftype { get; set; }

        [StringLength(6)]
        public string fpay_period { get; set; }

        public DateTime? fdateupd { get; set; }

        [Key]
        public int ID_SBTS { get; set; }

        [StringLength(20)]
        public string CREATEDBY { get; set; }

        public DateTime? CREATEDON { get; set; }

        [StringLength(20)]
        public string MODIFIEDBY { get; set; }

        public DateTime? MODIFIEDON { get; set; }
    }
}
