namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class c_paymt
    {
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal id { get; set; }

        [StringLength(1)]
        public string t { get; set; }

        [StringLength(2)]
        public string code { get; set; }

        [StringLength(6)]
        public string from { get; set; }

        [StringLength(6)]
        public string to { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? famt { get; set; }

        public int? flf { get; set; }

        [StringLength(2)]
        public string fschme { get; set; }

        [StringLength(25)]
        public string CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        [StringLength(25)]
        public string ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool? DeleteFlag { get; set; }
    }
}
