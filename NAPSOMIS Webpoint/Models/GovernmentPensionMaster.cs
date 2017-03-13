namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GovernmentPensionMaster")]
    public partial class GovernmentPensionMaster
    {
        [StringLength(17)]
        public string fnewssno { get; set; }

        [StringLength(17)]
        public string fssno { get; set; }

        [StringLength(12)]
        public string fclaim_no { get; set; }

        [StringLength(3)]
        public string floc { get; set; }

        [StringLength(1)]
        public string fsex { get; set; }

        [StringLength(45)]
        public string fsurname { get; set; }

        [StringLength(45)]
        public string firstname { get; set; }

        [StringLength(40)]
        public string fothname { get; set; }

        [StringLength(100)]
        public string flast_emp { get; set; }

        [StringLength(30)]
        public string flast_desig { get; set; }

        [StringLength(60)]
        public string faddress { get; set; }

        public DateTime? fterm_date { get; set; }

        [StringLength(45)]
        public string flocation { get; set; }

        [StringLength(30)]
        public string fpay_point { get; set; }

        [StringLength(7)]
        public string fbnk { get; set; }

        [StringLength(40)]
        public string fbnk_name { get; set; }

        [StringLength(40)]
        public string fbrnch { get; set; }

        [StringLength(30)]
        public string facctno { get; set; }

        public decimal? fterm_sal { get; set; }

        public DateTime? fapp_date { get; set; }

        [StringLength(2)]
        public string fbt_award { get; set; }

        [StringLength(1)]
        public string fpaymode { get; set; }

        [StringLength(1)]
        public string frequency { get; set; }

        public decimal? fnotimes_paid { get; set; }

        [StringLength(1)]
        public string fstatus { get; set; }

        public decimal? fgrant { get; set; }

        public DateTime? fstart_date { get; set; }

        public DateTime? fdue_date { get; set; }

        public decimal? fpen_right { get; set; }

        public decimal? ftimes_paid { get; set; }

        public decimal? ftotal_paid { get; set; }

        public decimal? fmonth_sal { get; set; }

        public decimal? fage { get; set; }

        public decimal? farrears { get; set; }

        public decimal? fpen_amt { get; set; }

        public decimal? funclaimed { get; set; }

        [StringLength(6)]
        public string flpay_perd { get; set; }

        [StringLength(6)]
        public string fprev_eperd { get; set; }

        public DateTime? frec_date { get; set; }

        [StringLength(2)]
        public string ftype { get; set; }

        [StringLength(6)]
        public string findex_perd { get; set; }

        public DateTime? fjoin_date { get; set; }

        [StringLength(4)]
        public string fentry { get; set; }

        public DateTime? fstop_date { get; set; }

        public DateTime? fract_date { get; set; }

        public DateTime? fdateupd { get; set; }

        [StringLength(25)]
        public string createdby { get; set; }

        public DateTime? createdon { get; set; }

        [StringLength(25)]
        public string modifiedby { get; set; }

        public DateTime? modifiedon { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fpen_amt_old { get; set; }

        [Key]
        public int ID_SBTS { get; set; }
    }
}
