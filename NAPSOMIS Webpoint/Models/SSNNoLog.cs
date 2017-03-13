namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SSNNoLog")]
    public partial class SSNNoLog
    {
        [StringLength(12)]
        public string fref_no { get; set; }

        [StringLength(17)]
        public string foldssno { get; set; }

        [StringLength(17)]
        public string fnewssno { get; set; }

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

        [StringLength(11)]
        public string ferno { get; set; }

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

        [StringLength(12)]
        public string fbatch_no { get; set; }

        [Key]
        public int ID_SBTS { get; set; }

        public bool? ftran_log { get; set; }
    }
}
