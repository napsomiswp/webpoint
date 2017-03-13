namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MemberCRMerge")]
    public partial class MemberCRMerge
    {
        [Key]
        public int ID_SBTS { get; set; }

        [StringLength(17)]
        public string fssno { get; set; }

        [StringLength(17)]
        public string brsssno { get; set; }

        [StringLength(50)]
        public string fsurname { get; set; }

        [StringLength(50)]
        public string firstname { get; set; }

        [StringLength(50)]
        public string fothname { get; set; }

        [StringLength(100)]
        public string fper_addr { get; set; }

        [StringLength(10)]
        public string createdby { get; set; }

        public DateTime? createdon { get; set; }

        [StringLength(10)]
        public string modifiedby { get; set; }

        public DateTime? modifiedon { get; set; }

        public bool? fflag { get; set; }
    }
}
