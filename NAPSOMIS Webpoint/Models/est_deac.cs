namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class est_deac
    {
        [StringLength(11)]
        public string ferno { get; set; }

        [StringLength(256)]
        public string femp_name { get; set; }

        [StringLength(6)]
        public string flast_period { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? flast_cr { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? flast_lf { get; set; }

        [StringLength(6)]
        public string freact_period { get; set; }

        public DateTime? fdate_deac { get; set; }

        public DateTime? fdate_react { get; set; }

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
