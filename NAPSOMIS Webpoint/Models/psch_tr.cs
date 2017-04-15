namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class psch_tr
    {
        [StringLength(17)]
        public string fssno { get; set; }

        [StringLength(12)]
        public string fdclaim_no { get; set; }

        [StringLength(25)]
        public string fn_surname { get; set; }

        [StringLength(20)]
        public string fn_frstnam { get; set; }

        [StringLength(20)]
        public string fn_othname { get; set; }

        [StringLength(200)]
        public string fsch_name { get; set; }

        [StringLength(1)]
        public string fsch_level { get; set; }

        public DateTime? fstart_date { get; set; }

        public DateTime? fcomp_date { get; set; }

        public DateTime? fdateupd { get; set; }

        [StringLength(25)]
        public string CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        [StringLength(25)]
        public string ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [Key]
        public int ID_SBTS { get; set; }
    }
}
