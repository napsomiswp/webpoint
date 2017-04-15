namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class eclc_mst
    {
        [StringLength(11)]
        public string ferno { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? fappl_date { get; set; }

        [StringLength(45)]
        public string fpurpose { get; set; }

        [StringLength(1)]
        public string fapprove { get; set; }

        [StringLength(3)]
        public string fappr_by { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? fappr_date { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? fissue_date { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? fexpire_date { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fduration { get; set; }

        [StringLength(6)]
        public string fuser { get; set; }

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
