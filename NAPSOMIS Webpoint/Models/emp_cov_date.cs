namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class emp_cov_date
    {
        public DateTime? fcov_date { get; set; }

        [StringLength(11)]
        public string ferno { get; set; }

        public DateTime? createdon { get; set; }

        [StringLength(50)]
        public string createdby { get; set; }

        public DateTime? modifiedon { get; set; }

        [StringLength(50)]
        public string modifiedby { get; set; }

        [Key]
        public int ID_SBTS { get; set; }
    }
}
