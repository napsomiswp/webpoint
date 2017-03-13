namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CashDenomination")]
    public partial class CashDenomination
    {
        [StringLength(2)]
        public string fcode { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ftype { get; set; }

        [StringLength(15)]
        public string fdesc { get; set; }

        [StringLength(2)]
        public string famttype { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fvalue { get; set; }

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
