using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace NAPSOMIS_Webpoint.ViewModels
    {
    public class GenerateSunTransactionViewModel
        {
        [Display(Name = "Receipt Date")]
        public DateTime? receiptdate { get; set; }

        [Display(Name = "Total Receipt")]
        public decimal? totalreceipt { get; set; }

        [Display(Name = "Total Banked")]
        public decimal? totalbanked { get; set; }

        [Display(Name = "Journal Transfers")]
        public decimal? journaltransfer { get; set; }

        [Display(Name = "Balance (Receipt Less Banked)")]
        public decimal? balance { get; set; }
        }
    }