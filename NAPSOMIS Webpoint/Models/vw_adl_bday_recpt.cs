namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_adl_bday_recpt
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(17)]
        public string fssno { get; set; }

        [StringLength(12)]
        public string fclaim_no { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(25)]
        public string fsurname { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string firstname { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(20)]
        public string fothname { get; set; }

        [StringLength(1)]
        public string fsex { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? fjoindate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? fbirth_dat { get; set; }

        [StringLength(2)]
        public string fben_type { get; set; }

        [StringLength(1)]
        public string fmst_statu { get; set; }

        [StringLength(7)]
        public string fpaypoint { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? fterm_date { get; set; }

        [StringLength(1)]
        public string frequency { get; set; }

        [StringLength(30)]
        public string fben_desc { get; set; }

        [StringLength(30)]
        public string fpay_pnt { get; set; }

        [StringLength(25)]
        public string freq { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? fdateupd { get; set; }
    }
}
