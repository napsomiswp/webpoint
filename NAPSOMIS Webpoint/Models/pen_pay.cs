namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class pen_pay
    {
        [StringLength(11)]
        public string ferno { get; set; }

        [StringLength(1)]
        public string ftype { get; set; }

        [StringLength(6)]
        public string fperiod { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fpencr { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fpen_amt { get; set; }

        [StringLength(60)]
        public string frecptno { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? frecptdate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? famount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fno_days { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? frate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fintpen { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? fdateupd { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fpen_pay { get; set; }

        [StringLength(6)]
        public string fuser_code { get; set; }

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
