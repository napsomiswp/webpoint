namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IntCalculation")]
    public partial class IntCalculation
    {
        [StringLength(11)]
        public string ferno { get; set; }

        [StringLength(6)]
        public string fperiod { get; set; }

        [StringLength(14)]
        public string frecptno { get; set; }

        public DateTime? fpaymt_date { get; set; }

        public int? fintRate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fPayAmt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fCrAmt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fIntAmt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fPenAmt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fIntDays { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fPenDays { get; set; }

        public DateTime? fpen_date { get; set; }

        [StringLength(25)]
        public string CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        [StringLength(25)]
        public string ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool? DeleteFlag { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Cur_Pay { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Cur_Contr { get; set; }

        [Key]
        public int ID_SBTS { get; set; }
    }
}
