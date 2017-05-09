using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace NAPSOMIS_Webpoint.ViewModels
    {
    public class ReverseCapturedContributionViewModel
        {
        [Display(Name = "ERNo")]
        public string ferno { get; set; }

         [Display(Name = "Establishment")]
        public string establishment { get; set; }

         [Display(Name = "Category")]
        public string fcat { get; set; }

         [Display(Name = "CR Type")]
        public string ftype { get; set; }

         [Display(Name = "Begin Period")]
        public string beginperiod { get; set; }

         [Display(Name = "End Period")]
        public string endperiod { get; set; }

         [Display(Name = "Debit")]
        public string debit { get; set; }

        }
    }