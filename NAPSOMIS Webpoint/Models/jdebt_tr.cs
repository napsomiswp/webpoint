namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class jdebt_tr
    {
        [StringLength(11)]
        public string ferno { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? fj_date { get; set; }

        [StringLength(6)]
        public string fbperiod { get; set; }

        [StringLength(6)]
        public string feperiod { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? famount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fpaid { get; set; }

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
