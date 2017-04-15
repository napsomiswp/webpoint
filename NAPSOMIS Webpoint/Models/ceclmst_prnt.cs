namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ceclmst_prnt
    {
        [StringLength(11)]
        public string ferno { get; set; }

        [StringLength(256)]
        public string femp_name { get; set; }

        public DateTime? fappl_date { get; set; }

        [StringLength(45)]
        public string fpurpose { get; set; }

        [StringLength(1)]
        public string fapprove { get; set; }

        [StringLength(3)]
        public string fappr_by { get; set; }

        public DateTime? fappr_date { get; set; }

        public DateTime? fissue_dat { get; set; }

        public DateTime? fexpire_da { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fduration { get; set; }

        [StringLength(6)]
        public string fuser { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fbalance { get; set; }

        public DateTime? flastinsp { get; set; }

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
