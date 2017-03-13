namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StopDependantPension")]
    public partial class StopDependantPension
    {
        [Required]
        [StringLength(17)]
        public string fssno { get; set; }

        [Required]
        [StringLength(12)]
        public string fdclaim_no { get; set; }

        public DateTime fstopdate { get; set; }

        public DateTime? factivationdate { get; set; }

        [Required]
        [StringLength(1)]
        public string fstatus { get; set; }

        [Required]
        [StringLength(1)]
        public string freason { get; set; }

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
