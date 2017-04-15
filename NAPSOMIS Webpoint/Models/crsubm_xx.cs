namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class crsubm_xx
    {
        [Column(TypeName = "numeric")]
        public decimal? fno { get; set; }

        [StringLength(11)]
        public string ferno { get; set; }

        [StringLength(256)]
        public string femp_name { get; set; }

        public DateTime? fcov_date { get; set; }

        [StringLength(4)]
        public string fyear { get; set; }

        [StringLength(1)]
        public string fjan { get; set; }

        [StringLength(1)]
        public string ffeb { get; set; }

        [StringLength(1)]
        public string fmar { get; set; }

        [StringLength(1)]
        public string fapr { get; set; }

        [StringLength(1)]
        public string fmay { get; set; }

        [StringLength(1)]
        public string fjun { get; set; }

        [StringLength(1)]
        public string fjul { get; set; }

        [StringLength(1)]
        public string faug { get; set; }

        [StringLength(1)]
        public string fsep { get; set; }

        [StringLength(1)]
        public string foct { get; set; }

        [StringLength(1)]
        public string fnov { get; set; }

        [StringLength(1)]
        public string fdec { get; set; }

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
