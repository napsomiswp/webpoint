namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DependantRelative")]
    public partial class DependantRelative
    {
        [StringLength(19)]
        public string fref_no { get; set; }

        [StringLength(17)]
        public string fbatch_no { get; set; }

        [StringLength(17)]
        public string fssno { get; set; }

        [StringLength(15)]
        public string fnom_ssno { get; set; }

        [StringLength(25)]
        public string fnsurname { get; set; }

        [StringLength(20)]
        public string fnfirstnam { get; set; }

        [StringLength(20)]
        public string fnothname { get; set; }

        [StringLength(1)]
        public string fnomsex { get; set; }

        public DateTime? fbirth_dat { get; set; }

        [StringLength(2)]
        public string frelation { get; set; }

        [StringLength(20)]
        public string frel_desc { get; set; }

        [StringLength(1)]
        public string fstatus { get; set; }

        [StringLength(60)]
        public string fper_addr { get; set; }

        [StringLength(60)]
        public string fres_addr { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fd_share { get; set; }

        [StringLength(1)]
        public string fd_status { get; set; }

        public DateTime? fdate_rel { get; set; }

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
