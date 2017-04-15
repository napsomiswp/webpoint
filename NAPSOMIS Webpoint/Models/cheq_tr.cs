namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class cheq_tr
    {
        [StringLength(13)]
        public string ferno { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? frecptdate { get; set; }

        [StringLength(15)]
        public string fcheqno { get; set; }

        [StringLength(14)]
        public string frecptno { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? fcheqdate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? famount { get; set; }

        [StringLength(30)]
        public string fbank_code { get; set; }

        [StringLength(6)]
        public string fr_loc { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? fdateupd { get; set; }

        [StringLength(6)]
        public string fuser_code { get; set; }

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
