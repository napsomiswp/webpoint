namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class cstmt_pg3_tab
    {
        [StringLength(17)]
        public string fssno { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fage { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fnmths_cr { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fcr_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fnmths_pur { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fpur_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fl36_mths { get; set; }

        [StringLength(1)]
        public string ffpen_q { get; set; }

        [StringLength(1)]
        public string frpen_q { get; set; }

        [StringLength(1)]
        public string fipen_q { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fgovt_val { get; set; }

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
