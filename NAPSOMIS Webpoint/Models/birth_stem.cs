namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class birth_stem
    {
        [StringLength(14)]
        public string fbirth_stem { get; set; }

        public decimal? flast_no { get; set; }

        public DateTime? flast_update { get; set; }

        [StringLength(25)]
        public string Createdby { get; set; }

        public DateTime? CreatedOn { get; set; }

        [StringLength(25)]
        public string Modifiedby { get; set; }

        [StringLength(25)]
        public string ModifiedOn { get; set; }

        [Key]
        public int ID_SBTS { get; set; }
    }
}
