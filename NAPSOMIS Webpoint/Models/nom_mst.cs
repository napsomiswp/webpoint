namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class nom_mst
    {
        [StringLength(12)]
        public string fref_no { get; set; }

        [StringLength(17)]
        public string fssno { get; set; }

        [StringLength(17)]
        public string fnom_ssno { get; set; }

        [StringLength(50)]
        public string fnsurname { get; set; }

        [StringLength(50)]
        public string fnfirstnam { get; set; }

        [StringLength(50)]
        public string fnothname { get; set; }

        [StringLength(1)]
        public string fnomsex { get; set; }

        public DateTime? fbirth_dat { get; set; }

        [StringLength(2)]
        public string frelation { get; set; }

        [StringLength(60)]
        public string fper_addr { get; set; }

        [StringLength(60)]
        public string fres_addr { get; set; }

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
