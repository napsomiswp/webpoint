namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DistrictLocation")]
    public partial class DistrictLocation
    {
        [StringLength(3)]
        public string floc { get; set; }

        [StringLength(30)]
        public string floc_name { get; set; }

        [StringLength(10)]
        public string fdist_alias { get; set; }

        [StringLength(35)]
        public string fdist_adr { get; set; }

        [StringLength(15)]
        public string fdist_tel { get; set; }

        [StringLength(15)]
        public string fdist_fax { get; set; }

        [StringLength(40)]
        public string fdist_mgr { get; set; }

        [StringLength(7)]
        public string fbnk_code { get; set; }

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
