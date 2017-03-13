namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CBBatch")]
    public partial class CBBatch
    {
        [StringLength(17)]
        public string fbatch_no { get; set; }

        [StringLength(50)]
        public string fdateupd { get; set; }

        [StringLength(20)]
        public string Createdby { get; set; }

        public DateTime? CreatedOn { get; set; }

        [StringLength(20)]
        public string Modifiedby { get; set; }

        public DateTime? Modifiedon { get; set; }

        [Key]
        public int idno { get; set; }
    }
}
