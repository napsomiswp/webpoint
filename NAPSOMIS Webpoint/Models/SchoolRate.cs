namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SchoolRate")]
    public partial class SchoolRate
    {
        [StringLength(2)]
        public string fcode { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? frate { get; set; }

        [StringLength(6)]
        public string fstart { get; set; }

        [StringLength(6)]
        public string fend { get; set; }

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
