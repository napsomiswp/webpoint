namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class insp_mst2
    {
        [StringLength(255)]
        public string ferno { get; set; }

        [StringLength(255)]
        public string floc { get; set; }

        [StringLength(255)]
        public string fzone { get; set; }

        [StringLength(255)]
        public string fpbperd { get; set; }

        [StringLength(255)]
        public string fpeperd { get; set; }

        public DateTime? flip_date { get; set; }

        [StringLength(255)]
        public string flb_perd { get; set; }

        [StringLength(255)]
        public string fle_perd { get; set; }

        [StringLength(255)]
        public string fpay_cat { get; set; }

        [StringLength(255)]
        public string fcr_cat { get; set; }

        [StringLength(255)]
        public string fest_cat { get; set; }

        [StringLength(255)]
        public string fppay_cat { get; set; }

        [StringLength(255)]
        public string fpcr_cat { get; set; }

        public DateTime? fnip_date { get; set; }

        [StringLength(255)]
        public string fnb_perd { get; set; }

        [StringLength(255)]
        public string fne_perd { get; set; }

        [StringLength(255)]
        public string finsp_pl { get; set; }

        [StringLength(255)]
        public string finsp_code { get; set; }

        [StringLength(255)]
        public string fstatus { get; set; }

        public bool fpcatch { get; set; }

        public bool fccatch { get; set; }

        [StringLength(255)]
        public string fprocessed { get; set; }

        [StringLength(255)]
        public string flpro_date { get; set; }

        public DateTime? fdateupd { get; set; }

        [Key]
        public int ID_SBTS { get; set; }

        [StringLength(20)]
        public string CREATEDBY { get; set; }

        public DateTime? CREATEDON { get; set; }

        [StringLength(20)]
        public string MODIFIEDBY { get; set; }

        public DateTime? MODIFIEDON { get; set; }
    }
}
