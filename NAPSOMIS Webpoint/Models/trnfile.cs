namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("trnfile")]
    public partial class trnfile
    {
        [StringLength(10)]
        public string facct_code { get; set; }

        [StringLength(5)]
        public string fblank1 { get; set; }

        [StringLength(7)]
        public string facct_per { get; set; }

        [StringLength(8)]
        public string ftr_date { get; set; }

        [StringLength(2)]
        public string fblank2 { get; set; }

        [StringLength(1)]
        public string frec_type { get; set; }

        [StringLength(7)]
        public string fjour_no { get; set; }

        [StringLength(7)]
        public string fjour_line { get; set; }

        public decimal? famount { get; set; }

        [StringLength(1)]
        public string fdr_cr_mak { get; set; }

        [StringLength(1)]
        public string falloc_ind { get; set; }

        [StringLength(5)]
        public string ftr_jr_typ { get; set; }

        [StringLength(5)]
        public string fsource { get; set; }

        [StringLength(15)]
        public string ftr_ref { get; set; }

        [StringLength(25)]
        public string fdescr { get; set; }

        [StringLength(8)]
        public string fentry_dat { get; set; }

        [StringLength(8)]
        public string fentry_per { get; set; }

        [StringLength(8)]
        public string fdue_date { get; set; }

        [StringLength(6)]
        public string fblank3 { get; set; }

        [StringLength(9)]
        public string fpay_allrf { get; set; }

        [StringLength(8)]
        public string fpay_aldat { get; set; }

        [StringLength(7)]
        public string fpay_allpe { get; set; }

        [StringLength(1)]
        public string fasset_ind { get; set; }

        [StringLength(10)]
        public string fasset_cod { get; set; }

        [StringLength(5)]
        public string fass_subco { get; set; }

        [StringLength(5)]
        public string fconv_code { get; set; }

        [StringLength(18)]
        public string fconv_rate { get; set; }

        public decimal? fother_amt { get; set; }

        [StringLength(1)]
        public string fno_dec_pl { get; set; }

        [StringLength(3)]
        public string fid_oper1 { get; set; }

        [StringLength(3)]
        public string fid_oper2 { get; set; }

        [StringLength(3)]
        public string fid_oper3 { get; set; }

        [StringLength(1)]
        public string freversal { get; set; }

        [StringLength(1)]
        public string ftext { get; set; }

        [StringLength(1)]
        public string fr_book_fg { get; set; }

        [StringLength(1)]
        public string fin_use_fg { get; set; }

        [StringLength(15)]
        public string ftrana_co0 { get; set; }

        [StringLength(15)]
        public string ftrana_co1 { get; set; }

        [StringLength(15)]
        public string ftrana_co2 { get; set; }

        [StringLength(15)]
        public string ftrana_co3 { get; set; }

        [StringLength(15)]
        public string ftrana_co4 { get; set; }

        [StringLength(15)]
        public string ftrana_co5 { get; set; }

        [StringLength(15)]
        public string ftrana_co6 { get; set; }

        [StringLength(15)]
        public string ftrana_co7 { get; set; }

        [StringLength(15)]
        public string ftrana_co8 { get; set; }

        [StringLength(15)]
        public string ftrana_co9 { get; set; }

        public DateTime? fpost_date { get; set; }

        [StringLength(1)]
        public string fup_or_bal { get; set; }

        [StringLength(112)]
        public string ffiller { get; set; }

        [StringLength(20)]
        public string CREATEDBY { get; set; }

        public DateTime? CREATEDON { get; set; }

        [StringLength(20)]
        public string MODIFIEDBY { get; set; }

        public DateTime? MODIFIEDON { get; set; }

        [Key]
        public int ID_SBTS { get; set; }
    }
}
