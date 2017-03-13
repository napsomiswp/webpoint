namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GeneralBank
    {
        [StringLength(4)]
        public string fcode { get; set; }

        [StringLength(30)]
        public string fbank { get; set; }

        [StringLength(20)]
        public string createdby { get; set; }

        public DateTime? createdon { get; set; }

        [StringLength(20)]
        public string modifiedby { get; set; }

        public DateTime? modifiedon { get; set; }

        [Key]
        public int ID_SBTS { get; set; }
    }
}
