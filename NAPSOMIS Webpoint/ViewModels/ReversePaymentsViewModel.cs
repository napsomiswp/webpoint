using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace NAPSOMIS_Webpoint.ViewModels
    {
    public class ReversePaymentsViewModel
        {
        [Display(Name = "Receipt No")]
        public string receiptno { get; set; }
         
        [Display(Name = "Receipt Date")]
        public DateTime? receiptdate { get; set; }

        [Display(Name = "ERNo")]
        public string ferno { get; set; }

        [Display(Name = "Establisment")]
        public string establishment { get; set; }

        [Display(Name = "Reason")]
        public string reason { get; set; }

        [Display(Name = "Total Amount on Receipt")]
        public decimal? totalamount { get; set; }
        }
    }