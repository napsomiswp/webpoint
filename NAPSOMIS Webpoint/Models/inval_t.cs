namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class inval_t
    {
        [StringLength(17)]
        public string fssno { get; set; }

        [StringLength(1)]
        public string ftype_cr { get; set; }

        [StringLength(11)]
        public string ferno { get; set; }

        [StringLength(1)]
        public string fcat { get; set; }

        [StringLength(12)]
        public string fpcentre { get; set; }

        [StringLength(25)]
        public string fsurname { get; set; }

        [StringLength(20)]
        public string firstname { get; set; }

        [StringLength(20)]
        public string fothername { get; set; }

        [StringLength(15)]
        public string fstaffno { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? famount { get; set; }

        [StringLength(6)]
        public string fperiod { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? fdateupd { get; set; }

        public bool? fflag { get; set; }

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
