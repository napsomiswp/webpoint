using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NAPSOMIS_Webpoint.ViewModels
    {
    public class CRSRegViewModel
        {
        
        [StringLength(25)]
        [Display(Name = "ERNo")]
        public string ferno { get; set; }

        [StringLength(25)]
        [Display(Name = "Category")]
        public string fcat { get; set; }

        [StringLength(25)]
        [Display(Name = "Type of Contribution")]
        public string ftype { get; set; }

        [StringLength(1)]
        [Display(Name = "Media")]
        public string fmedia { get; set; }

        [StringLength(25)]
        [Display(Name = "Submission Mode")]
        public string fmode { get; set; }
 
        [Display(Name = "Date Received")]
        public DateTime? fdate_rec { get; set; }

        [Display(Name = "Begin Period")]
        public string fperiod { get; set; }

        [Display(Name = "End Period")]
        public string feperiod { get; set; }
         
        public string fperiodrange { get; set; }

        [StringLength(1)]
        [Display(Name = "Backpay Type")]
        public string fbaktype { get; set; }

        [Column(TypeName="numeric")]
        [Display(Name = "No. of Workers")]
        public int? fnowkr { get; set; }

        [Column(TypeName="numeric")]
        [Display(Name = "Total Contribution")]
        public decimal? ftot_cr { get; set; }

        [Display(Name = "Status")]
        public string fstatus { get; set; }

        [Display(Name = "Scheme")]
        public string fscheme { get; set; }

        [Display(Name = "Date Updated")]
        public DateTime? fdateupd { get; set; }

        [Display(Name = "Period")]
        public string dperiod { get; set; }

        [Key]
        public int ID_SBTS { get; set; }

        }
    }