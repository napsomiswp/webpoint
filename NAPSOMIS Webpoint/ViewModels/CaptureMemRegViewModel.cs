using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NAPSOMIS_Webpoint.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MemberTransaction")]
    public partial class CaptureMemRegViewModel
    {
        //MEMBER TRANSACTION FIELDS

        [StringLength(17)]
        [Display(Name="Batch")]
        public string fbatch { get; set; }

        [StringLength(12)]
        [Display(Name="Reference No")]
        public string fref_no { get; set; }

        [StringLength(17)]
        [Display(Name = "SSNo")]
        public string fssno { get; set; }

        [StringLength(25)]
        [Display(Name = "Surname")]
        public string fsurname { get; set; }

        [StringLength(20)]
        [Display(Name = "First Name")]
        public string firstname { get; set; }

        [StringLength(20)]
        [Display(Name = "Other Name")]
        public string fothname { get; set; }

        [StringLength(60)]
        [Display(Name = "Permanent Address")]
        public string fper_addr { get; set; }

        [StringLength(60)]
        [Display(Name = "Current Address")]
        public string fcur_addr { get; set; }

        [StringLength(1)]
        [Display(Name = "Marital Status")]
        public string fm_stat { get; set; }

        [StringLength(30)]
        [Display(Name = "Nationality")]
        public string fnation { get; set; }

        [StringLength(40)]
        [Display(Name = "Country")]
        public string fb_country { get; set; }

        [StringLength(1)]
        [Display(Name = "Sex")]
        public string fsex { get; set; }

        [StringLength(1)]
        [Display(Name = "Province")]
        public string fprovince { get; set; }

        [StringLength(2)]
        [Display(Name = "District")]
        public string fdist { get; set; }

        [StringLength(2)]
        [Display(Name = "Chiefdom")]
        public string fchief { get; set; }

        [StringLength(40)]
        [Display(Name = "Town")]
        public string ftown { get; set; }

        [Display(Name = "Date of Birth")]
        public DateTime? fb_date { get; set; }

        [Display(Name = "Join Date")]
        public DateTime? fjoindate { get; set; }

        [Column(TypeName = "numeric")]
        [Display(Name = "Income")]
        public decimal? fincome { get; set; }

        [StringLength(1)]
        [Display(Name = "Nature of Income")]
        public string fnat_income { get; set; }

        [StringLength(6)]
        [Display(Name = "Occupation")]
        public string foccupation { get; set; }

        [StringLength(256)]
        [Display(Name = "Employer")]
        public string femp_name { get; set; }

        [StringLength(11)]
        [Display(Name = "Employer Reg No")]
        public string ferno { get; set; }

        [StringLength(60)]
        [Display(Name = "Employer Address")]
        public string femp_addr { get; set; }

        [StringLength(15)]
        [Display(Name = "Tel No")]
        public string ftel_no { get; set; }

        [StringLength(3)]
        [Display(Name = "Floc")]
        public string floc { get; set; }

        [StringLength(1)]
        [Display(Name = "Query")]
        public string fquery { get; set; }

        [Display(Name = "Reg Date")]
        public DateTime? freg_date { get; set; }

        [Display(Name = "Date Updated")]
        public DateTime? fdateupd { get; set; }

        [StringLength(6)]
        [Display(Name = "User Captured")]
        public string fuser_cap { get; set; }

        [StringLength(15)]
        [Display(Name = "Staff No")]
        public string fstaffno { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fcr_mths { get; set; }

        [Display(Name = "Generated Date")]
        public DateTime? fgen_date { get; set; }

        [StringLength(1)]
        [Display(Name = "Status")]
        public string fstatus { get; set; }

        [StringLength(25)]
        public string CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        [StringLength(25)]
        public string ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool? DeleteFlag { get; set; }

        [StringLength(3)]
        [Display(Name = "Government Code")]
        public string fgov_code { get; set; }

        [Key]
        public int ID_SBTS { get; set; }



        //PARENTAL FIELDS
        [StringLength(25)]
        [Display(Name = "Surname")]
        public string ffsurname { get; set; }

        [StringLength(20)]
        [Display(Name = "First Name")]
        public string ffirstname { get; set; }

        [StringLength(20)]
        [Display(Name = "Other Name")]
        public string ffothname { get; set; }

        [StringLength(25)]
        [Display(Name = "Surname")]
        public string fmsurname { get; set; }

        [StringLength(20)]
        [Display(Name = "First Name")]
        public string fmfirstname { get; set; }

        [StringLength(20)]
        [Display(Name = "Other Name")]
        public string fmothname { get; set; }

 
    }
}