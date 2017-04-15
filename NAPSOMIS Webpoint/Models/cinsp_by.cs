namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class cinsp_by
    {
        [StringLength(11)]
        public string ferno { get; set; }

        [StringLength(256)]
        public string femp_name { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? flf { get; set; }

        [StringLength(6)]
        public string insp_bperd { get; set; }

        [StringLength(6)]
        public string insp_eperd { get; set; }

        [StringLength(30)]
        public string insp_place { get; set; }

        public DateTime? insp_date { get; set; }

        [StringLength(6)]
        public string insp_code { get; set; }

        [StringLength(80)]
        public string fremark { get; set; }

        [StringLength(8)]
        public string fuser { get; set; }

        [StringLength(1)]
        public string fstatus { get; set; }

        [StringLength(1)]
        public string insp_type { get; set; }

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
