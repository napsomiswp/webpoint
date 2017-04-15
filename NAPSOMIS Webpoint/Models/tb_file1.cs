namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_file1
    {
        [StringLength(255)]
        public string fperiod { get; set; }

        public double? frate { get; set; }

        [StringLength(255)]
        public string CreatedBy { get; set; }

        [StringLength(255)]
        public string CreatedOn { get; set; }

        [StringLength(255)]
        public string ModifiedBy { get; set; }

        [StringLength(255)]
        public string ModifiedOn { get; set; }

        [StringLength(255)]
        public string DeleteFlag { get; set; }

        [Key]
        public int ID_SBTS { get; set; }
    }
}
