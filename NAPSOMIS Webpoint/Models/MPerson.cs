namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MPerson")]
    public partial class MPerson
    {
        [StringLength(20)]
        public string fssno { get; set; }

        [StringLength(20)]
        public string fref_no { get; set; }

        public DateTime? fgen_date { get; set; }

        [StringLength(50)]
        public string MotherNm { get; set; }

        [StringLength(50)]
        public string FatherNm { get; set; }

        [StringLength(100)]
        public string Provience { get; set; }

        [StringLength(100)]
        public string District { get; set; }

        [StringLength(100)]
        public string ChiefDom { get; set; }

        [Key]
        public int idnow { get; set; }
    }
}
