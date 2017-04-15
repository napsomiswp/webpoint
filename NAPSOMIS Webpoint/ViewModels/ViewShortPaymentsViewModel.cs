using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace NAPSOMIS_Webpoint.ViewModels
    {
    public class ViewShortPaymentsViewModel
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
 
        }
    }