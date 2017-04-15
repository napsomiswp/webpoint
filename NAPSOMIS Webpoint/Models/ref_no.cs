namespace NAPSOMIS_Webpoint.Models
    {
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ref_no
        {
        [Key]
        [StringLength(4)]
        public string fyear { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fserial { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fl_qty { get; set; }

        [StringLength(6)]
        public string fuser_code { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? fdateupd { get; set; }

        [StringLength(25)]
        public string CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        [StringLength(10)]
        public string Centre { get; set; }

        [StringLength(25)]
        public string ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool? DeleteFlag { get; set; }

        public int refID { get; set; }

        }
    }
