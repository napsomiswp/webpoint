namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("users")]
    public partial class user1
    {
        [StringLength(6)]
        public string user_code { get; set; }

        [StringLength(25)]
        public string user_name { get; set; }

        [StringLength(8)]
        public string passw { get; set; }

        [StringLength(3)]
        public string user_grp { get; set; }

        [StringLength(2)]
        public string user_level { get; set; }

        [StringLength(15)]
        public string duration_pass { get; set; }

        [StringLength(8)]
        public string passw_prev { get; set; }

        public DateTime? expiry_date { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? last_warn { get; set; }

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
