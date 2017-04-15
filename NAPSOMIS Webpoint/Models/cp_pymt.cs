namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class cp_pymt
    {
        [StringLength(11)]
        public string ferno { get; set; }

        [StringLength(6)]
        public string fperiod { get; set; }

        [StringLength(14)]
        public string frecptno { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? frecptdate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fcr_paid { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fint_paid { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fpen_paid { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fpayno { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ftotpays { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? frcpt_date { get; set; }

        [StringLength(1)]
        public string fstatus { get; set; }

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
