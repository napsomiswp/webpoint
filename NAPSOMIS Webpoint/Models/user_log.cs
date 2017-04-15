namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class user_log
    {
        [StringLength(20)]
        public string user_code { get; set; }

        public DateTime? login_date { get; set; }

        [StringLength(1)]
        public string login_status { get; set; }

        public DateTime? logout_date { get; set; }

        [StringLength(50)]
        public string IP_Address { get; set; }

        [StringLength(100)]
        public string machine_name { get; set; }

        [Key]
        public int ID_SBTS { get; set; }

        [StringLength(20)]
        public string CREATEDBY { get; set; }

        public DateTime? CREATEDON { get; set; }

        [StringLength(20)]
        public string MODIFIEDBY { get; set; }

        public DateTime? MODIFIEDON { get; set; }

        [StringLength(15)]
        public string fupdateApp { get; set; }
    }
}
