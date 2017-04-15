namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class gb_brnch
    {
        [StringLength(4)]
        public string fbnk_code { get; set; }

        [StringLength(7)]
        public string fbrnch_code { get; set; }

        [StringLength(30)]
        public string fbrnch_name { get; set; }

        [StringLength(10)]
        public string facct_cde { get; set; }

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
