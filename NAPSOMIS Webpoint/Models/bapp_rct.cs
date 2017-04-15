namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class bapp_rct
    {
        [Key]
        [StringLength(17)]
        public string fssno { get; set; }

        [StringLength(12)]
        public string fclaim_no { get; set; }

        [StringLength(100)]
        public string fsurname { get; set; }

        [StringLength(100)]
        public string firstname { get; set; }

        [StringLength(100)]
        public string fothname { get; set; }

        [StringLength(1)]
        public string fsex { get; set; }

        [StringLength(1)]
        public string ftype_app { get; set; }

        public DateTime? fbirth_date { get; set; }

        public DateTime? fapp_date { get; set; }

        public DateTime? fjoindate { get; set; }

        [StringLength(2)]
        public string fben_type { get; set; }

        [StringLength(1)]
        public string fmst_status { get; set; }

        [StringLength(40)]
        public string fapp_status { get; set; }

        [StringLength(7)]
        public string fpaypoint { get; set; }

        public DateTime? fterm_date { get; set; }

        [StringLength(1)]
        public string frequency { get; set; }

        public DateTime? fdateupd { get; set; }

        [StringLength(25)]
        public string CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        [StringLength(25)]
        public string ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool? DeleteFlag { get; set; }

        [StringLength(50)]
        public string src_contr { get; set; }
    }
}
