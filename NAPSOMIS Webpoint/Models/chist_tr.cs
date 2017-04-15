namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class chist_tr
    {
        [StringLength(17)]
        public string fssno { get; set; }

        [StringLength(1)]
        public string fupd_type { get; set; }

        [StringLength(11)]
        public string ferno { get; set; }

        [StringLength(1)]
        public string fcat { get; set; }

        [StringLength(12)]
        public string fpcentre { get; set; }

        [StringLength(25)]
        public string fsurname { get; set; }

        [StringLength(20)]
        public string firstname { get; set; }

        [StringLength(20)]
        public string fothername { get; set; }

        [StringLength(15)]
        public string fstaffno { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fcur_cr { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? flast_cr { get; set; }

        [StringLength(6)]
        public string fcurcr_per { get; set; }

        [StringLength(6)]
        public string fbak_bperd { get; set; }

        [StringLength(6)]
        public string fbak_eperd { get; set; }

        [StringLength(17)]
        public string fid { get; set; }

        [StringLength(1)]
        public string fremark { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? fdateupd { get; set; }

        [StringLength(17)]
        public string fcorr_ssno { get; set; }

        public bool? fflag { get; set; }

        [StringLength(25)]
        public string CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        [StringLength(25)]
        public string ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool? DeleteFlag { get; set; }

        [StringLength(2)]
        public string fflagtran { get; set; }

        [Key]
        public int ID_SBTS { get; set; }
    }
}
