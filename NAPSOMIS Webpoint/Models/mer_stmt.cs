namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mer_stmt
    {
        [StringLength(17)]
        public string fssno { get; set; }

        [StringLength(11)]
        public string ferno { get; set; }

        [StringLength(1)]
        public string fcat { get; set; }

        [StringLength(60)]
        public string fname { get; set; }

        [StringLength(1)]
        public string fsex { get; set; }

        public DateTime? fjoinedate { get; set; }

        [StringLength(256)]
        public string femp_name { get; set; }

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

        [Column(TypeName = "numeric")]
        public decimal? fbjancr { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fbfebcr { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fbmarcr { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fbaprcr { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fbmaycr { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fbjuncr { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fbjulcr { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fbaugcr { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fbsepcr { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fboctcr { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fbnovcr { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fbdeccr { get; set; }

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
