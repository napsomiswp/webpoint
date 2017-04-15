namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class c_cheq
    {
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal id { get; set; }

        [StringLength(15)]
        public string cheqno { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? fdate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? famt { get; set; }

        [StringLength(4)]
        public string fbnk { get; set; }

        public string fbrnch { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? fdateupd { get; set; }

        [StringLength(3)]
        public string fr_loc { get; set; }

        [StringLength(14)]
        public string frecptno { get; set; }

        [StringLength(15)]
        public string fchequeno { get; set; }

        [StringLength(25)]
        public string CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        [StringLength(25)]
        public string ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool? DeleteFlag { get; set; }
    }
}
