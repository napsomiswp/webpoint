namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PensionCheque")]
    public partial class PensionCheque
    {
        [StringLength(13)]
        public string fssno { get; set; }

        [StringLength(12)]
        public string fclaim_no { get; set; }

        [StringLength(45)]
        public string fname { get; set; }

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

        [Key]
        public int ID_SBTS { get; set; }

        [StringLength(20)]
        public string CREATEDBY { get; set; }

        public DateTime? CREATEDON { get; set; }

        [StringLength(20)]
        public string MODIFIEDBY { get; set; }

        public DateTime? MODIFIEDON { get; set; }
    }
}
