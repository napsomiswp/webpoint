using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace NAPSOMIS_Webpoint.ViewModels
    {
    public class CaptureBankLodgementViewModel
        {
        [Display(Name = "Receipt Date")]
        public DateTime? receiptdate { get; set; }

         [Display(Name = "Cheque")]
        public decimal? cheque { get; set; }

         [Display(Name = "Journal Transfer")]
        public decimal? journaltransfer { get; set; }

         [Display(Name = "Bank Advice")]
        public decimal? bankadvice { get; set; }

         [Display(Name = "Cash")]
        public decimal? cash { get; set; }

         [Display(Name = "Total Collected")]
        public decimal? totalcollected { get; set; }

        
         [Display(Name = "Total to Bank")]
        public decimal? totaltobank { get; set; }

        }
    }