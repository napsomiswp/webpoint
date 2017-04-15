namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class cr_post
    {
        public bool? fprocess { get; set; }

        [StringLength(6)]
        public string fperiod { get; set; }

        [StringLength(11)]
        public string ferno { get; set; }

        [StringLength(256)]
        public string femp_name { get; set; }

        [StringLength(1)]
        public string ftype_cr { get; set; }

        public decimal? fcontr { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fcr_file { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fcr_paid { get; set; }

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
