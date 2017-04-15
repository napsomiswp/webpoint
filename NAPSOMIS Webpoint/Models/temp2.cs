namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class temp2
    {
        [StringLength(11)]
        public string ferno { get; set; }

        [StringLength(6)]
        public string insp_bperd { get; set; }

        [StringLength(6)]
        public string insp_eperd { get; set; }

        [StringLength(30)]
        public string insp_place { get; set; }

        [Column(TypeName = "smalldatetime")]
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

        [Column(TypeName = "smalldatetime")]
        public DateTime? fdateupd { get; set; }

        [StringLength(25)]
        public string CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        [StringLength(25)]
        public string ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool? DeleteFlag { get; set; }

        [StringLength(256)]
        public string femp_name { get; set; }

        [Required]
        [StringLength(1)]
        public string noofw { get; set; }

        [Key]
        public int ID_SBTS { get; set; }
    }
}
