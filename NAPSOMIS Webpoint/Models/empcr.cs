namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("empcr")]
    public partial class empcr
    {
        [StringLength(11)]
        public string ferno { get; set; }

        [StringLength(1)]
        public string ftype_cr { get; set; }

        [StringLength(1)]
        public string fcat { get; set; }

        [StringLength(6)]
        public string fperiod { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fno_wkr { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ftot_cont { get; set; }

        [StringLength(14)]
        public string frecptno { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? famount { get; set; }

        [StringLength(2)]
        public string fpaytype { get; set; }

        [StringLength(12)]
        public string fapen_perd { get; set; }

        [StringLength(12)]
        public string frpen_perd { get; set; }

        [Column(TypeName = "smalldatetime")]
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
