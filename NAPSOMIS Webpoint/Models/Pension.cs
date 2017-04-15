namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class pension
    {
        [StringLength(24)]
        public string pension_id { get; set; }

        [Column("____pen_st")]
        [StringLength(20)]
        public string C____pen_st { get; set; }

        [Column("____old_pe")]
        [StringLength(26)]
        public string C____old_pe { get; set; }

        [Column("____period")]
        public decimal? C____period { get; set; }

        [Column("____fin_ye")]
        public decimal? C____fin_ye { get; set; }

        [Column("____first_")]
        [StringLength(23)]
        public string C____first_ { get; set; }

        [Column("____second")]
        [StringLength(26)]
        public string C____second { get; set; }

        [Column("____surnam")]
        [StringLength(31)]
        public string C____surnam { get; set; }

        [Column("____last_w")]
        [StringLength(36)]
        public string C____last_w { get; set; }

        [Column("____last_d")]
        [StringLength(27)]
        public string C____last_d { get; set; }

        [Column("____addres")]
        [StringLength(51)]
        public string C____addres { get; set; }

        [Column("____locati")]
        [StringLength(19)]
        public string C____locati { get; set; }

        [Column("____catego")]
        [StringLength(19)]
        public string C____catego { get; set; }

        [Column("____mode_p")]
        [StringLength(20)]
        public string C____mode_p { get; set; }

        [Column("____freque")]
        [StringLength(20)]
        public string C____freque { get; set; }

        [Column("____bank_i")]
        public decimal? C____bank_i { get; set; }

        [Column("____bank_n")]
        [StringLength(34)]
        public string C____bank_n { get; set; }

        [Column("____branch")]
        [StringLength(36)]
        public string C____branch { get; set; }

        [Column("____branc2")]
        [StringLength(23)]
        public string C____branc2 { get; set; }

        [Column("____accoun")]
        [StringLength(22)]
        public string C____accoun { get; set; }

        [Column("____payee_")]
        [StringLength(38)]
        public string C____payee_ { get; set; }

        [Column("____arrear")]
        public decimal? C____arrear { get; set; }

        [Column("____net_am")]
        public decimal? C____net_am { get; set; }

        [Column("____pay_th")]
        public decimal? C____pay_th { get; set; }

        [Column("____unclai")]
        [StringLength(26)]
        public string C____unclai { get; set; }

        [Column("____agd_re")]
        [StringLength(9)]
        public string C____agd_re { get; set; }

        [Key]
        public int ID_SBTS { get; set; }

        [StringLength(20)]
        public string CREATEDBY { get; set; }

        public DateTime? CREATEDON { get; set; }

        [StringLength(20)]
        public string MODIFIEDBY { get; set; }

        public DateTime? MODIFIEDON { get; set; }
    }
}
