namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class pros_tr
    {
        [StringLength(11)]
        public string ferno { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? fpros_date { get; set; }

        [StringLength(30)]
        public string fcourt { get; set; }

        [StringLength(35)]
        public string fjudge1 { get; set; }

        [StringLength(35)]
        public string fproscutor { get; set; }

        [StringLength(25)]
        public string freason { get; set; }

        [StringLength(6)]
        public string fbperiod { get; set; }

        [StringLength(6)]
        public string feperiod { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? fdate_end { get; set; }

        [StringLength(25)]
        public string fverdict { get; set; }

        [StringLength(35)]
        public string fjudge2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fcost { get; set; }

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
