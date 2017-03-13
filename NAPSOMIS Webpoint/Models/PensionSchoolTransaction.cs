namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PensionSchoolTransaction")]
    public partial class PensionSchoolTransaction
    {
        [StringLength(17)]
        public string fssno { get; set; }

        [StringLength(12)]
        public string fdclaim_no { get; set; }

        [StringLength(50)]
        public string fn_surname { get; set; }

        [StringLength(50)]
        public string fn_frstnam { get; set; }

        [StringLength(50)]
        public string fn_othname { get; set; }

        [StringLength(100)]
        public string fsch_name { get; set; }

        [StringLength(1)]
        public string fsch_level { get; set; }

        public DateTime? fstart_date { get; set; }

        public DateTime? fcomp_date { get; set; }

        public DateTime? fdateupd { get; set; }

        [Key]
        public int ID_SBTS { get; set; }

        [StringLength(20)]
        public string CREATEDBY { get; set; }

        public DateTime? CREATEDON { get; set; }

        [StringLength(20)]
        public string MODIFIEDBY { get; set; }

        public DateTime? MODIFIEDON { get; set; }
    }
}
