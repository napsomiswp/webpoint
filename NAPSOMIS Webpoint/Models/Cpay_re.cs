namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cpay_re
    {
        [StringLength(17)]
        public string ferno { get; set; }

        [StringLength(14)]
        public string frecptno { get; set; }

        public DateTime? frecptdate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? famount { get; set; }

        [StringLength(1)]
        public string freason { get; set; }

        [StringLength(6)]
        public string fuser_code { get; set; }

        public DateTime? fdateupd { get; set; }

        [StringLength(25)]
        public string CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        [StringLength(25)]
        public string ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool? DeleteFlag { get; set; }

        [StringLength(50)]
        public string fname { get; set; }

        [StringLength(50)]
        public string fuser { get; set; }

        [Key]
        public int ID_SBTS { get; set; }
    }
}
