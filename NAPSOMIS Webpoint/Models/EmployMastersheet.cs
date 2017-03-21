namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmployMastersheet")]
    public partial class EmployMastersheet
    {
        [Key]
        [StringLength(11)]
        [Display(Name = "ERNo")]
        public string ferno { get; set; }

        [StringLength(256)]
        [Display(Name = "Establishment Name")]
        public string femp_name { get; set; }

        [StringLength(3)]
        [Display(Name = "Floc")]
        public string floc { get; set; }

        [StringLength(265)]
        [Display(Name = "Address Line 1")]
        public string faddress1 { get; set; }

        [StringLength(265)]
        [Display(Name = "Address Line 2")]
        public string faddress2 { get; set; }

        [StringLength(20)]
        [Display(Name = "Town")]
        public string ftown { get; set; }

        [StringLength(15)]
        [Display(Name = "Tel No")]
        public string ftelno { get; set; }

        [StringLength(45)]
        [Display(Name = "Contact Person")]
        public string fcontact { get; set; }

        [StringLength(256)]
        [Display(Name = "Actual Location of Establishment")]
        public string fsite { get; set; }

        [StringLength(1)]
        [Display(Name = "I. Economic Activity")]
        public string fiecon_act { get; set; }

        [StringLength(1)]
        [Display(Name = "Economic Activity")]
        public string fecon_act { get; set; }

        [StringLength(1)]
        [Display(Name = "Name Of Business")]
        public string fowner { get; set; }

        [StringLength(15)]
        [Display(Name = "Certificate No")]
        public string fcert_no { get; set; }

        [Display(Name = "Certificate Date")]
        public DateTime? fcert_date { get; set; }

        [StringLength(15)]
        [Display(Name = "Commencement No.")]
        public string fcomm_cno { get; set; }

        [Display(Name = "Commencement Date")]
        public DateTime? fcomm_date { get; set; }

        [Display(Name = "Coverable Date")]
        public DateTime? fcov_date { get; set; }

        [StringLength(1)]
        [Display(Name = "Business Type")]
        public string fbusn_type { get; set; }

        [StringLength(1)]
        [Display(Name = "Establishment Type")]
        public string fest_type { get; set; }


        [Display(Name = "Inspection Date")]
        public DateTime? finsp_date { get; set; }

        [Display(Name = "Registration Date")]
        public DateTime freg_date { get; set; }

        [StringLength(1)]
        [Display(Name = "Status")]
        public string fstatus { get; set; }

        [StringLength(1)]
        [Display(Name = "Mode of Submission")]
        public string fprint { get; set; }

        [StringLength(50)]
        [Display(Name = "Nature")]
        public string fnature { get; set; }

        [StringLength(1)]
        [Display(Name = "Salary Mode")]
        public string fsalpatt { get; set; }

        [StringLength(10)]
        [Display(Name = "Zone")]
        public string fzone { get; set; }

        [StringLength(2)]
        [Display(Name = "Scheme")]
        public string fschme { get; set; }

        [Display(Name = "Date Created")]
        public DateTime? fdate_created { get; set; }

        [Display(Name = "Date Updated")]
        public DateTime? fdateupd { get; set; }

        [StringLength(25)]
        public string CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        [StringLength(25)]
        public string ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool? DeleteFlag { get; set; }
    }
}
