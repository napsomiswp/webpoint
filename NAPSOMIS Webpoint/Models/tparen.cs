namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tparen")]
    public partial class tparen
    {
        [StringLength(12)]
        public string fref_no { get; set; }

        [StringLength(17)]
        public string fssno { get; set; }

        [StringLength(25)]
        public string ffsurname { get; set; }

        [StringLength(20)]
        public string ffirstname { get; set; }

        [StringLength(20)]
        public string ffothname { get; set; }

        [StringLength(25)]
        public string fmsurname { get; set; }

        [StringLength(20)]
        public string fmfirstname { get; set; }

        [StringLength(20)]
        public string fmothname { get; set; }

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
