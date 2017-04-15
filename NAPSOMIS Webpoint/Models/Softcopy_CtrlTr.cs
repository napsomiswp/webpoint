namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Softcopy_CtrlTr
    {
        [StringLength(12)]
        public string ferno { get; set; }

        [StringLength(3)]
        public string floc { get; set; }

        [StringLength(1)]
        public string ftype { get; set; }

        public decimal? ftotalAmt { get; set; }

        public decimal? ftotalrec { get; set; }

        [StringLength(6)]
        public string fperiod { get; set; }

        [StringLength(6)]
        public string fbperiod { get; set; }

        [StringLength(6)]
        public string feperiod { get; set; }

        [StringLength(1)]
        public string ftran_log { get; set; }

        [StringLength(20)]
        public string Createdby { get; set; }

        public DateTime? Createdon { get; set; }

        [StringLength(20)]
        public string Modifiedby { get; set; }

        public DateTime? Modifiedon { get; set; }

        [Key]
        public int ID_SBTS { get; set; }

        public int? fbaktype { get; set; }
    }
}
