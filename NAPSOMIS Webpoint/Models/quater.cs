namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("quater")]
    public partial class quater
    {
        [StringLength(1)]
        public string fcode { get; set; }

        [StringLength(30)]
        public string fdesc { get; set; }

        [StringLength(15)]
        public string fmth1 { get; set; }

        [StringLength(15)]
        public string fmth2 { get; set; }

        [StringLength(15)]
        public string fmth3 { get; set; }

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
