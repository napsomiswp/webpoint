namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class emp_ledg
    {
        [StringLength(11)]
        public string ferno { get; set; }

        [StringLength(4)]
        public string fyear { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fcrbal { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fpenbal { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fint_bal { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fcont_pay { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ftot_cont { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ftot_pen { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ftot_int { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fpen_pay { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fint_pay { get; set; }

        [StringLength(6)]
        public string flpen_perd { get; set; }

        [StringLength(2)]
        public string fneg { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fnet_bal { get; set; }

        public DateTime? fdateupd { get; set; }

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
