namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Existing_mem_chk
    {
        public int id { get; set; }

        [StringLength(50)]
        public string Fssno { get; set; }

        public int? Flag { get; set; }

        public DateTime? CreatedOn { get; set; }

        [StringLength(50)]
        public string RefNo { get; set; }

        [StringLength(20)]
        public string CREATEDBY { get; set; }

        [StringLength(20)]
        public string MODIFIEDBY { get; set; }

        public DateTime? MODIFIEDON { get; set; }
    }
}
