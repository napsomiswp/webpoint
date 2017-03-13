namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MemberGeneral")]
    public partial class MemberGeneral
    {
        [StringLength(17)]
        public string fbatch { get; set; }

        [StringLength(255)]
        public string fref_no { get; set; }

        [StringLength(170)]
        public string fssno { get; set; }

        [StringLength(255)]
        public string fsurname { get; set; }

        [StringLength(255)]
        public string firstname { get; set; }

        [StringLength(255)]
        public string fothname { get; set; }

        [StringLength(255)]
        public string fper_addr { get; set; }

        [StringLength(255)]
        public string fcur_addr { get; set; }

        [StringLength(255)]
        public string fm_stat { get; set; }

        [StringLength(255)]
        public string fnation { get; set; }

        [StringLength(255)]
        public string fb_country { get; set; }

        [StringLength(255)]
        public string fsex { get; set; }

        [StringLength(255)]
        public string fprovince { get; set; }

        [StringLength(255)]
        public string fdist { get; set; }

        [StringLength(255)]
        public string fchief { get; set; }

        [StringLength(255)]
        public string ftown { get; set; }

        public DateTime? fb_date { get; set; }

        public DateTime? fjoindate { get; set; }

        public double? fincome { get; set; }

        [StringLength(255)]
        public string fnat_incom { get; set; }

        [StringLength(255)]
        public string foccupatio { get; set; }

        [StringLength(256)]
        public string femp_name { get; set; }

        [StringLength(255)]
        public string ferno { get; set; }

        [StringLength(255)]
        public string femp_addr { get; set; }

        [StringLength(255)]
        public string ftel_no { get; set; }

        [StringLength(255)]
        public string floc { get; set; }

        [StringLength(255)]
        public string fquery { get; set; }

        public DateTime? freg_date { get; set; }

        public DateTime? fdateupd { get; set; }

        [StringLength(255)]
        public string fuser_cap { get; set; }

        public DateTime? fgen_date { get; set; }

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
