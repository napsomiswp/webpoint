namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class cmemsip_tr
    {
        [StringLength(17)]
        public string fssno { get; set; }

        [StringLength(45)]
        public string fsurname { get; set; }

        [StringLength(35)]
        public string firstname { get; set; }

        [StringLength(35)]
        public string fothname { get; set; }

        [StringLength(1)]
        public string fsex { get; set; }

        public DateTime? fb_date { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fage { get; set; }

        [StringLength(3)]
        public string floc { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fannsal { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fnoyr { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? factors { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fcost { get; set; }

        [StringLength(1)]
        public string fappr_cde { get; set; }

        public DateTime? fappr_date { get; set; }

        [StringLength(6)]
        public string fappr_by { get; set; }

        [StringLength(6)]
        public string fuser_cap { get; set; }

        [StringLength(1)]
        public string fprnt { get; set; }

        public DateTime? fdateupd { get; set; }

        [StringLength(40)]
        public string fappr_name { get; set; }

        [StringLength(1)]
        public string fstatus { get; set; }

        [StringLength(40)]
        public string floc_name { get; set; }

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
