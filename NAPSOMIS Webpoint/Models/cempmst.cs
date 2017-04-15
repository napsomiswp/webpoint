namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("cempmst")]
    public partial class cempmst
    {
        [StringLength(11)]
        public string ferno { get; set; }

        [StringLength(256)]
        public string femp_name { get; set; }

        [StringLength(3)]
        public string floc { get; set; }

        [StringLength(265)]
        public string faddress1 { get; set; }

        [StringLength(265)]
        public string faddress2 { get; set; }

        [StringLength(20)]
        public string ftown { get; set; }

        [StringLength(15)]
        public string ftelno { get; set; }

        [StringLength(45)]
        public string fcontact { get; set; }

        [StringLength(256)]
        public string fsite { get; set; }

        [StringLength(1)]
        public string fiecon_act { get; set; }

        [StringLength(1)]
        public string fecon_act { get; set; }

        [StringLength(1)]
        public string fowner { get; set; }

        [StringLength(15)]
        public string fcert_no { get; set; }

        public DateTime? fcert_date { get; set; }

        [StringLength(15)]
        public string fcomm_cno { get; set; }

        public DateTime? fcomm_date { get; set; }

        public DateTime? fcov_date { get; set; }

        [StringLength(1)]
        public string fbusn_type { get; set; }

        [StringLength(1)]
        public string fest_type { get; set; }

        public DateTime? finsp_date { get; set; }

        public DateTime? freg_date { get; set; }

        [StringLength(1)]
        public string fstatus { get; set; }

        [StringLength(1)]
        public string fprint { get; set; }

        [StringLength(40)]
        public string fnature { get; set; }

        [StringLength(1)]
        public string fsalpatt { get; set; }

        [StringLength(3)]
        public string fzone { get; set; }

        [StringLength(2)]
        public string fschme { get; set; }

        public DateTime? fdate_crea { get; set; }

        [StringLength(1)]
        public string fpay_cat { get; set; }

        [StringLength(1)]
        public string fcr_cat { get; set; }

        [StringLength(1)]
        public string fest_cat { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fpay_lf { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fcr_lf { get; set; }

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
