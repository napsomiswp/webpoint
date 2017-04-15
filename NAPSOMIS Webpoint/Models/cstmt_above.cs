namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class cstmt_above
    {
        [StringLength(17)]
        public string fssno { get; set; }

        [StringLength(11)]
        public string ferno { get; set; }

        [StringLength(1)]
        public string fcat { get; set; }

        [StringLength(1)]
        public string ftype { get; set; }

        [StringLength(4)]
        public string fyear { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fjancr { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ffebcr { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fmarcr { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? faprcr { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fmaycr { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fjuncr { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fjulcr { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? faugcr { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fsepcr { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? foctcr { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fnovcr { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fdeccr { get; set; }

        [StringLength(15)]
        public string fstaffno { get; set; }

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
