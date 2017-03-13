namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Bank")]
    public partial class Bank
    {
        [Display(Name ="Code")]
        [Required]
        [StringLength(4)]
        public string fcode { get; set; }

        [Display(Name ="Bank")]
        [Required]
        [StringLength(30)]
        public string fbank { get; set; }

        [Display(Name ="Created By")]
        [StringLength(25)]
        public string CreatedBy { get; set; }

        [Display(Name ="Created On")]
        public DateTime? CreatedOn { get; set; }

        [Display(Name ="Modidied By")]
        [StringLength(25)]
        public string ModifiedBy { get; set; }

        [Display(Name = "Modified  On")]
        public DateTime? ModifiedOn { get; set; }

        [Display(Name = "Delete Flaq")]
        public bool? DeleteFlag { get; set; }

        [Required]
        [Key]
        public int ID_SBTS { get; set; }
    }
}
