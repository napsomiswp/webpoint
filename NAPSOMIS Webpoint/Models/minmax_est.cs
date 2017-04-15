namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class minmax_est
    {
        [StringLength(4)]
        public string fyear { get; set; }

        [StringLength(2)]
        public string fmonth { get; set; }

        [StringLength(11)]
        public string ferno { get; set; }

        [StringLength(3)]
        public string ftype { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? favgcont { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fno_wkr { get; set; }

        public DateTime? fdateupd { get; set; }

        [StringLength(25)]
        public string Createdby { get; set; }

        public DateTime? CreatedOn { get; set; }

        [StringLength(25)]
        public string Modifiedby { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [Key]
        public int ID_SBTS { get; set; }
    }
}
