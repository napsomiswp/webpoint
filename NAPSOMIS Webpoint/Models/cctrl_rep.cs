namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class cctrl_rep
    {
        [Column(TypeName = "numeric")]
        public decimal? ftype { get; set; }

        [StringLength(15)]
        public string fdesc { get; set; }

        [StringLength(2)]
        public string frank { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fno { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? famt { get; set; }

        [StringLength(6)]
        public string fuser_code { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? frecptdate { get; set; }

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
