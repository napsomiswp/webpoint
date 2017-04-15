namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class gre_tran
    {
        [StringLength(12)]
        public string ffile { get; set; }

        [StringLength(1)]
        public string ftype { get; set; }

        public decimal? frec_no { get; set; }

        [StringLength(18)]
        public string fref_no { get; set; }

        public DateTime? fdate { get; set; }

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
