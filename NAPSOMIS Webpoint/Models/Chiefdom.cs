namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Chiefdom")]
    public partial class Chiefdom
    {
        [StringLength(1)]
        public string fp_code { get; set; }

        [StringLength(2)]
        public string fd_code { get; set; }

        [StringLength(2)]
        public string fc_code { get; set; }

        [StringLength(35)]
        public string fdescr { get; set; }

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
