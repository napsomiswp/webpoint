namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GovernmentHistoryMaster")]
    public partial class GovernmentHistoryMaster
    {
        [StringLength(17)]
        public string fssno { get; set; }

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

        [StringLength(6)]
        public string frstcr_perd { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fcur_cr { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? flast_cr { get; set; }

        [StringLength(6)]
        public string fcurcr_perd { get; set; }

        [StringLength(1)]
        public string fremark { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? fdateupd { get; set; }

        public bool? fedit { get; set; }

        [StringLength(1)]
        public string fprocess { get; set; }

        [StringLength(17)]
        public string fid { get; set; }

        public bool? fflag { get; set; }

        public bool? finflag { get; set; }

        [StringLength(6)]
        public string fcatbperd { get; set; }

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
