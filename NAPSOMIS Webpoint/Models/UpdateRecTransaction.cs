namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UpdateRecTransaction")]
    public partial class UpdateRecTransaction
    {
        [StringLength(17)]
        public string fssno { get; set; }

        [StringLength(1)]
        public string fupd_type { get; set; }

        [StringLength(25)]
        public string fsurname { get; set; }

        [StringLength(20)]
        public string firstname { get; set; }

        [StringLength(20)]
        public string fothname { get; set; }

        [StringLength(1)]
        public string fstatus { get; set; }

        public DateTime? fdate_rec { get; set; }

        [StringLength(6)]
        public string fuser_rec { get; set; }

        public DateTime? fdate_cap { get; set; }

        [StringLength(6)]
        public string fuser_cap { get; set; }

        [StringLength(1)]
        public string fsex { get; set; }

        public bool? fn_chg { get; set; }

        public bool? fd_chg { get; set; }

        public bool? fm_chg { get; set; }

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
