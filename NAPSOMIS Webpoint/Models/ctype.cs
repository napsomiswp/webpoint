namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ctype")]
    public partial class ctype
    {
        [StringLength(2)]
        public string code { get; set; }

        [StringLength(30)]
        public string descr { get; set; }

        [StringLength(10)]
        public string dr_acct { get; set; }

        [StringLength(10)]
        public string cr_acct { get; set; }

        [StringLength(5)]
        public string jtype { get; set; }

        [StringLength(1)]
        public string t { get; set; }

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
