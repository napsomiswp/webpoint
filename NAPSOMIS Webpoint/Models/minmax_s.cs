namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class minmax_s
    {
        [StringLength(4)]
        public string fyear { get; set; }

        [StringLength(2)]
        public string fmonth { get; set; }

        [StringLength(3)]
        public string floc { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fmincont { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fmaxcont { get; set; }

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
