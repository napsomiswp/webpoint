namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class m_stmt
    {
        [StringLength(17)]
        public string fssno { get; set; }

        [StringLength(11)]
        public string ferno { get; set; }

        [StringLength(50)]
        public string fname { get; set; }

        [StringLength(1)]
        public string fsex { get; set; }

        public DateTime? fjoinedate { get; set; }

        [StringLength(256)]
        public string femp_name { get; set; }

        [StringLength(4)]
        public string fyear { get; set; }

        [StringLength(2)]
        public string fmonth { get; set; }

        [StringLength(1)]
        public string ftype { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fcontr { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fbakpay { get; set; }

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
