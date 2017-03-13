namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChequeMaster")]
    public partial class ChequeMaster
    {
        [StringLength(13)]
        public string fssno { get; set; }

        [StringLength(12)]
        public string fclaim_no { get; set; }

        [StringLength(7)]
        public string fbnk { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ftimes_run { get; set; }

        [StringLength(6)]
        public string fpay_perio { get; set; }

        [StringLength(45)]
        public string fname { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? famount { get; set; }

        [StringLength(14)]
        public string fcheq_no { get; set; }

        [StringLength(60)]
        public string fbrnch { get; set; }

        [StringLength(30)]
        public string facct_no { get; set; }

        [StringLength(254)]
        public string fwordl1 { get; set; }

        [StringLength(90)]
        public string fwordl2 { get; set; }

        [StringLength(100)]
        public string fwordl3 { get; set; }

        [StringLength(60)]
        public string fdamt { get; set; }

        [StringLength(13)]
        public string fssno1 { get; set; }

        [StringLength(12)]
        public string fclaim_no1 { get; set; }

        [StringLength(45)]
        public string fname1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? famount1 { get; set; }

        [StringLength(14)]
        public string fcheq_no1 { get; set; }

        [StringLength(60)]
        public string fbrnch1 { get; set; }

        [StringLength(254)]
        public string fwordl11 { get; set; }

        [StringLength(90)]
        public string fwordl21 { get; set; }

        [StringLength(100)]
        public string fwordl31 { get; set; }

        [StringLength(60)]
        public string fdamt1 { get; set; }

        [StringLength(13)]
        public string fssno2 { get; set; }

        [StringLength(12)]
        public string fclaim_no2 { get; set; }

        [StringLength(45)]
        public string fname2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? famount2 { get; set; }

        [StringLength(14)]
        public string fcheq_no2 { get; set; }

        [StringLength(40)]
        public string fbrnch2 { get; set; }

        [StringLength(254)]
        public string fwordl12 { get; set; }

        [StringLength(90)]
        public string fwordl22 { get; set; }

        [StringLength(100)]
        public string fwordl32 { get; set; }

        [StringLength(60)]
        public string fdamt2 { get; set; }

        [StringLength(1)]
        public string ftype { get; set; }

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
