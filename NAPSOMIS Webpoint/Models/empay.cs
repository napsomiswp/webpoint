namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("empay")]
    public partial class empay
    {
        [StringLength(17)]
        public string ferno { get; set; }

        [StringLength(17)]
        public string fssno { get; set; }

        [StringLength(200)]
        public string fname { get; set; }

        [StringLength(2)]
        public string fpaytype { get; set; }

        [StringLength(6)]
        public string fperiod { get; set; }

        [StringLength(6)]
        public string fe_period { get; set; }

        [StringLength(14)]
        public string frecptno { get; set; }

        public DateTime? frecptdate { get; set; }

        public DateTime? fpaymt_dat { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? famount { get; set; }

        [StringLength(1)]
        public string fused { get; set; }

        [StringLength(6)]
        public string fuser_code { get; set; }

        [StringLength(35)]
        public string fuser_name { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? flf { get; set; }

        [StringLength(6)]
        public string fr_loc { get; set; }

        public DateTime? fdateupd { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fkount { get; set; }

        [StringLength(5)]
        public string fcode { get; set; }

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
