namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class cest_covdate
    {
        [StringLength(11)]
        public string ferno { get; set; }

        [StringLength(256)]
        public string femp_name { get; set; }

        public DateTime? fcov_date { get; set; }

        public DateTime? fcov_date1 { get; set; }

        [StringLength(6)]
        public string fuser { get; set; }

        [StringLength(45)]
        public string fuser_name { get; set; }

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
