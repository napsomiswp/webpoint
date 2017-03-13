namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InspectionMaster")]
    public partial class InspectionMaster
    {
        [StringLength(11)]
        public string ferno { get; set; }

        [StringLength(3)]
        public string floc { get; set; }

        [StringLength(2)]
        public string fzone { get; set; }

        public DateTime? flip_date { get; set; }

        [StringLength(6)]
        public string flb_perd { get; set; }

        [StringLength(6)]
        public string fle_perd { get; set; }

        [StringLength(1)]
        public string fpay_cat { get; set; }

        [StringLength(1)]
        public string fcr_cat { get; set; }

        [StringLength(1)]
        public string fppay_cat { get; set; }

        [StringLength(1)]
        public string fpcr_cat { get; set; }

        public DateTime? fnip_date { get; set; }

        [StringLength(6)]
        public string fnb_perd { get; set; }

        [StringLength(6)]
        public string fne_perd { get; set; }

        [StringLength(20)]
        public string finsp_pl { get; set; }

        [StringLength(2)]
        public string finsp_code { get; set; }

        [StringLength(1)]
        public string fstatus { get; set; }

        public bool? fpcatch { get; set; }

        public bool? fccatch { get; set; }

        [StringLength(1)]
        public string fprocessed { get; set; }

        public DateTime? flpro_date { get; set; }

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
