namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NomTemp")]
    public partial class NomTemp
    {
        [StringLength(12)]
        [Display(Name ="Reference No")]
        public string fref_no { get; set; }

        [StringLength(17)]
        [Display(Name ="SSNo")]
        public string fssno { get; set; }

        [StringLength(17)]
        [Display(Name ="Dependant SSNo")]
        public string fnom_ssno { get; set; }

        [StringLength(25)]
        [Display(Name ="Surname")]
        public string fnsurname { get; set; }

        [StringLength(20)]
        [Display(Name ="First Name")]
        public string fnfirstname { get; set; }

        [StringLength(20)]
        [Display(Name ="Other Name")]
        public string fnothname { get; set; }

        [StringLength(1)]
        [Display(Name ="Sex")]
        public string fnomsex { get; set; }

        [Display(Name ="Date of Birth")]
        public DateTime? fbirth_date { get; set; }

        [StringLength(20)]
        [Display(Name ="Relation")]
        public string frelation { get; set; }

        [StringLength(60)]
        [Display(Name ="Permanent Address")]
        public string fper_addr { get; set; }

        [StringLength(60)]
        [Display(Name ="Residential Address")]
        public string fres_addr { get; set; }

        [StringLength(6)]
        [Display(Name ="Captured By")]
        public string fuser_cap { get; set; }

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
