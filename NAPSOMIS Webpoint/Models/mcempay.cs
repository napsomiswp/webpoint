namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("mcempay")]
    public partial class mcempay
    {
        [StringLength(17)]
        public string fssno { get; set; }

        [StringLength(14)]
        public string frecptno { get; set; }

        public DateTime? fpaymtdate { get; set; }

        public DateTime? frecptdate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fnomths { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? famt_paid { get; set; }

        [StringLength(6)]
        public string fcashier { get; set; }

        public DateTime? fdateupd { get; set; }

        public DateTime? fb_date { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fannsal { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fnoyr { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? factors { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fcost { get; set; }

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
