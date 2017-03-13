namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MemberOnlineLog")]
    public partial class MemberOnlineLog
    {
        [StringLength(3)]
        public string floc { get; set; }

        [StringLength(16)]
        public string fref_stem { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fref_last { get; set; }

        public bool? Tran_log { get; set; }

        [StringLength(25)]
        public string CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        [StringLength(25)]
        public string ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool? DeleteFlag { get; set; }

        [Key]
        public int ID_SBTS { get; set; }
    }
}
