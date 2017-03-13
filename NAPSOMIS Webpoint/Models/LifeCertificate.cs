namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LifeCertificate")]
    public partial class LifeCertificate
    {
        [StringLength(48)]
        public string floc { get; set; }

        [StringLength(48)]
        public string floc1 { get; set; }

        [StringLength(17)]
        public string fssno { get; set; }

        [StringLength(12)]
        public string fclaim_no { get; set; }

        [StringLength(45)]
        public string fname { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fage { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fage_mth { get; set; }

        public DateTime? fb_date { get; set; }

        public DateTime? fdate_iss { get; set; }

        [StringLength(17)]
        public string fssno1 { get; set; }

        [StringLength(12)]
        public string fclaim_no1 { get; set; }

        [StringLength(45)]
        public string fname1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fage1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fage_mth1 { get; set; }

        public DateTime? fb_date1 { get; set; }

        public DateTime? fdate_iss1 { get; set; }

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
