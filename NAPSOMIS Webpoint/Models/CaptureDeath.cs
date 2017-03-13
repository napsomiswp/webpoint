namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CaptureDeath")]
    public partial class CaptureDeath
    {
        [StringLength(17)]
        public string fssno { get; set; }

        [StringLength(60)]
        public string fdth_cause { get; set; }

        [StringLength(40)]
        public string fdth_place { get; set; }

        public DateTime? fdth_date { get; set; }

        public DateTime? fapp_date { get; set; }

        [StringLength(200)]
        public string fdeath_reporter { get; set; }

        [StringLength(15)]
        public string freporter_tel { get; set; }

        public int? deceased_status { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ftimes_paid { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ftotal_paid { get; set; }

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
