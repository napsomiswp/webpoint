namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mem_tm3
    {
        [StringLength(12)]
        public string fref_no { get; set; }

        [StringLength(17)]
        public string fssno { get; set; }

        [StringLength(15)]
        public string fstaffno { get; set; }

        [StringLength(50)]
        public string fsurname { get; set; }

        [StringLength(50)]
        public string firstname { get; set; }

        [StringLength(50)]
        public string fothname { get; set; }

        [StringLength(60)]
        public string fper_addr { get; set; }

        [StringLength(60)]
        public string fcur_addr { get; set; }

        [StringLength(1)]
        public string fm_stat { get; set; }

        [StringLength(30)]
        public string fnation { get; set; }

        [StringLength(40)]
        public string fb_country { get; set; }

        [StringLength(1)]
        public string fsex { get; set; }

        [StringLength(1)]
        public string fprovince { get; set; }

        [StringLength(2)]
        public string fdist { get; set; }

        [StringLength(2)]
        public string fchief { get; set; }

        [StringLength(40)]
        public string ftown { get; set; }

        public DateTime? fb_date { get; set; }

        public DateTime? fjoindate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fincome { get; set; }

        [StringLength(1)]
        public string fnat_incom { get; set; }

        [StringLength(6)]
        public string foccupatio { get; set; }

        [StringLength(256)]
        public string femp_name { get; set; }

        [StringLength(11)]
        public string ferno { get; set; }

        [StringLength(60)]
        public string femp_addr { get; set; }

        [StringLength(15)]
        public string ftel_no { get; set; }

        [StringLength(3)]
        public string floc { get; set; }

        [StringLength(1)]
        public string fquery { get; set; }

        public DateTime? freg_date { get; set; }

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

        public bool? ftrans_log { get; set; }
    }
}
