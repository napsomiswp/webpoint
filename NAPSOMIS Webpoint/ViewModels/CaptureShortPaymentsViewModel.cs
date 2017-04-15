using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace NAPSOMIS_Webpoint.ViewModels
    {
    public class CaptureShortPaymentsViewModel
        {
      
        [Display(Name = "ERNo")]
        public string ferno { get; set; }
  
        [Display(Name = "Name of Establishment")]
        public string femp_name { get; set; }
  
        [Display(Name = "Category")]
        public string fcat { get; set; }
 
        [Display(Name = "Period")]
        public string fperiod { get; set; }
         
         [Display(Name = "Type")]
        public string ftype { get; set; }
 
        [Display(Name = "Found")]
        public bool ffoundstatus { get; set; }
         

        [Display(Name = "Cr. on File")]
        public decimal? fcronfile { get; set; }

        [Display(Name = "Status")]
        public string fstatus { get; set; }

        [Display(Name = "Correct Cr. Amount")]
        public decimal? fcorrectcramount { get; set; }

        [Display(Name = "Difference")]
        public decimal? fdifference { get; set; }
         

         [Display(Name = "SSNo")]
        public string fssno { get; set; }

         [Display(Name = "First Name")]
        public string ffirstname { get; set; }

         [Display(Name = "Other Name")]
        public string fothername { get; set; }

         [Display(Name = "Surname")]
        public string fsurname { get; set; }

         [Display(Name = "Staff Number")]
        public string fstaffno { get; set; }

        }
    }