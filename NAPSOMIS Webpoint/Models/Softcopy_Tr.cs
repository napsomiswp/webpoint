namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Softcopy_Tr
    {
        [StringLength(20)]
        public string fcode { get; set; }

        [StringLength(12)]
        public string ferno { get; set; }

        [StringLength(3)]
        public string floc { get; set; }

        [StringLength(1)]
        public string ftype { get; set; }

        [StringLength(17)]
        public string fssno { get; set; }

        [StringLength(100)]
        public string fname { get; set; }

        [StringLength(100)]
        public string fname1 { get; set; }

        [StringLength(100)]
        public string fname2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fcontr { get; set; }

        public DateTime? fdate { get; set; }

        [StringLength(20)]
        public string fstaffno { get; set; }

        [StringLength(6)]
        public string fperiod { get; set; }

        [StringLength(6)]
        public string fbperiod { get; set; }

        [StringLength(6)]
        public string feperiod { get; set; }

        public DateTime? fbak_begin { get; set; }

        public DateTime? fbak_end { get; set; }

        [StringLength(1)]
        public string fbaktype { get; set; }

        [StringLength(10)]
        public string fmisc { get; set; }

        [StringLength(2)]
        public string fflag { get; set; }

        [StringLength(1)]
        public string ftran_log { get; set; }

        [StringLength(20)]
        public string Createdby { get; set; }

        public DateTime? Createdon { get; set; }

        [StringLength(20)]
        public string Modifiedby { get; set; }

        public DateTime? Modifiedon { get; set; }

        [Key]
        public int ID_SBTS { get; set; }
    }
}
