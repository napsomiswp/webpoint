namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PreviousName")]
    public partial class PreviousName
    {
        [StringLength(12)]
        public string fref_no { get; set; }

        [StringLength(17)]
        public string fssno { get; set; }

        [StringLength(25)]
        public string fpsurname { get; set; }

        [StringLength(20)]
        public string fpfirstname { get; set; }

        [StringLength(20)]
        public string fpothname { get; set; }

        [StringLength(6)]
        public string fuser_code { get; set; }

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
