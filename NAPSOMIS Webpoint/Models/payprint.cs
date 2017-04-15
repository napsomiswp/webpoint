namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("payprint")]
    public partial class payprint
    {
        [StringLength(17)]
        public string ferno { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? frecptdate { get; set; }

        [StringLength(14)]
        public string frecptno { get; set; }

        [StringLength(254)]
        public string fwordl1 { get; set; }

        [StringLength(90)]
        public string fwordl2 { get; set; }

        [StringLength(100)]
        public string fwordl3 { get; set; }

        [StringLength(60)]
        public string fdamt { get; set; }

        [StringLength(60)]
        public string fnarration { get; set; }

        [StringLength(1500)]
        public string fnaration { get; set; }

        [StringLength(1500)]
        public string fnaration1 { get; set; }

        [StringLength(70)]
        public string fcheq1 { get; set; }

        [StringLength(17)]
        public string ftotal { get; set; }

        [StringLength(1)]
        public string fboth { get; set; }

        [StringLength(256)]
        public string femp_name { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fcont { get; set; }

        [StringLength(200)]
        public string fstation { get; set; }

        [StringLength(8)]
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
