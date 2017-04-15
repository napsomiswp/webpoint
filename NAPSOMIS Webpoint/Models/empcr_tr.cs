namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class empcr_tr
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(11)]
        public string ferno { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(1)]
        public string ftype_cr { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(1)]
        public string fcat { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(6)]
        public string fperiod { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fno_wkr { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ftot_cont { get; set; }

        [StringLength(12)]
        public string fapen_perd { get; set; }

        [StringLength(12)]
        public string frpen_perd { get; set; }

        [StringLength(2)]
        public string fschme { get; set; }

        public DateTime? fdateupd { get; set; }

        [StringLength(8)]
        public string fuser_code { get; set; }

        [StringLength(25)]
        public string CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        [StringLength(25)]
        public string ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool? DeleteFlag { get; set; }
    }
}
