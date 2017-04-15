namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class b_brnch
    {
        [Required]
        [StringLength(4)]
        public string fbnk_code { get; set; }

        [Key]
        [StringLength(7)]
        public string fbrnch_code { get; set; }

        [StringLength(30)]
        public string fbrnch_name { get; set; }

        [StringLength(10)]
        public string facct_cde { get; set; }

        [StringLength(25)]
        public string CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        [StringLength(25)]
        public string ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool? DeleteFlag { get; set; }
    }
}
