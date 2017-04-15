namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PrintCard")]
    public partial class PrintCard
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(17)]
        public string fssno { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool fprint { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string fusercode { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(100)]
        public string fusername { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime fprintdate { get; set; }

        [StringLength(20)]
        public string freceiptno { get; set; }

        public DateTime? freceiptdate { get; set; }

        [StringLength(10)]
        public string Createdby { get; set; }

        public DateTime? Createdon { get; set; }

        [StringLength(10)]
        public string Modifiedby { get; set; }

        public DateTime? Modifiedon { get; set; }
    }
}
