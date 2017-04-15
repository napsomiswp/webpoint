namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class minmax_t5
    {
        [StringLength(11)]
        public string ferno { get; set; }

        [Required]
        [StringLength(3)]
        public string ftype { get; set; }

        [StringLength(4)]
        public string fyear { get; set; }

        [StringLength(2)]
        public string fmonth { get; set; }

        public decimal? favgcont { get; set; }

        public int? fno_wkr { get; set; }

        public DateTime fdateupd { get; set; }

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
