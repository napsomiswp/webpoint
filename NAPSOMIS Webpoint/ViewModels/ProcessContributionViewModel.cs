using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace NAPSOMIS_Webpoint.ViewModels
    {
    public class ProcessContributionViewModel
        {
        [Display(Name = "Period")]
        public string fperiod { get; set; }

         [Display(Name = "Establishment")]
        public string femp_name { get; set; }

         [Display(Name = "Type")]
        public string ftype { get; set; }

         [Display(Name = "Contribution")]
        public decimal? fcontr { get; set; }

         [Display(Name = "Contribution on File")]
        public decimal? fcontr_onfile { get; set; }

         [Display(Name = "Amount Paid")]
        public decimal? famountpaid { get; set; }
        }
    }