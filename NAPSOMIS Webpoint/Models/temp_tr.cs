namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class temp_tr
    {
        [StringLength(1)]
        public string fcode { get; set; }

        [StringLength(13)]
        public string ferno { get; set; }

        [StringLength(17)]
        public string fssno { get; set; }

        [StringLength(100)]
        public string fname { get; set; }

        [StringLength(100)]
        public string fname1 { get; set; }

        [StringLength(100)]
        public string fname2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fcontr { get; set; }

        public DateTime? fdate { get; set; }

        [StringLength(15)]
        public string fstaffno { get; set; }

        [StringLength(6)]
        public string fbak_begin { get; set; }

        [StringLength(6)]
        public string fbak_end { get; set; }

        [StringLength(1)]
        public string fbaktype { get; set; }

        [StringLength(20)]
        public string fmisc { get; set; }

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
