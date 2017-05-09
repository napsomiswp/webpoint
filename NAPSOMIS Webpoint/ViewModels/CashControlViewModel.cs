using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace NAPSOMIS_Webpoint.ViewModels
    {
    public class CashControlViewModel
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

         [Display(Name = "Total Captured")]
        public decimal? totalcaptured { get; set; }

         [Display(Name = "Total Amount")]
        public decimal? totalamount { get; set; }

        [Display(Name = "Edit")]
        public bool edit { get; set; }


         [Display(Name = "Difference")]
        public decimal? totaldifference { get; set; }

         [Display(Name = "Currency")]
        public string currency { get; set; }

         [Display(Name = "Quantity")]
        public decimal currencyquantity { get; set; }

         [Display(Name = "Total")]
        public decimal currencytotalamount { get; set; }


        }
    }
 