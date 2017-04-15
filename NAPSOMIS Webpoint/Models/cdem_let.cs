namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class cdem_let
    {
        [StringLength(11)]
        public string ferno { get; set; }

        [StringLength(256)]
        public string femp_name { get; set; }

        [StringLength(6)]
        public string fb_perd { get; set; }

        [StringLength(6)]
        public string fe_perd { get; set; }

        [StringLength(6)]
        public string fperiod { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fcrbal { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fint_bal { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fpen_bal { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fcr_cbal { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fint_cbal { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fpen_cbal { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fp_cr { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fp_int { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fp_pen { get; set; }

        [StringLength(10)]
        public string fp_perd { get; set; }

        public DateTime? fpen_date { get; set; }

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
