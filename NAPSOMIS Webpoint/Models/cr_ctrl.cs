namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class cr_ctrl
    {
        [StringLength(11)]
        public string ferno { get; set; }

        [StringLength(1)]
        public string fcat { get; set; }

        public int? ftotwkr { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ftotcr { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? fdateupd { get; set; }

        [StringLength(1)]
        public string fmode { get; set; }

        [StringLength(6)]
        public string fuser_code { get; set; }

        [StringLength(1)]
        public string fmedia { get; set; }

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
