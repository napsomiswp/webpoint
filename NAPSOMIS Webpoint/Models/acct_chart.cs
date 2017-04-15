namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class acct_chart
    {
        [StringLength(1)]
        public string fbus_type { get; set; }

        [StringLength(1)]
        public string fpay_type { get; set; }

        [StringLength(5)]
        public string fcode { get; set; }

        [StringLength(15)]
        public string ftcde_0 { get; set; }

        [StringLength(15)]
        public string ftcde_1 { get; set; }

        [StringLength(15)]
        public string ftcde_2 { get; set; }

        [StringLength(15)]
        public string ftcde_3 { get; set; }

        [StringLength(15)]
        public string ftcde_4 { get; set; }

        [StringLength(15)]
        public string ftcde_5 { get; set; }

        [StringLength(15)]
        public string ftcde_6 { get; set; }

        [StringLength(15)]
        public string ftcde_7 { get; set; }

        [StringLength(15)]
        public string ftcde_8 { get; set; }

        [StringLength(15)]
        public string ftcde_9 { get; set; }

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
