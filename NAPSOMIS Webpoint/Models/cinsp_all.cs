namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class cinsp_all
    {
        [StringLength(6)]
        public string insp_code { get; set; }

        [StringLength(45)]
        public string fname { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fno_nests { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fno_sests { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? flf_n { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? flf_s { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fno_compn { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fno_comps { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fno_ncmpn { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fno_ncmps { get; set; }

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
