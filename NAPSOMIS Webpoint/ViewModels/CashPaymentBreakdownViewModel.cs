using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace NAPSOMIS_Webpoint.ViewModels
    {
    public class CashPaymentBreakdownViewModel
        {
        [Display(Name  = "Code")]
        public string fCode { get; set; }

        [Display(Name  = "Type")]
        public string fType { get; set; }

        [Display(Name  = "From")]
        public string fFrom { get; set; }

        [Display(Name  = "To")]
        public string fTo { get; set; }

        [Display(Name  = "Amount")]
        public decimal? fAmount { get; set; }

        [Display(Name  = "LF")]
        public int? fLF { get; set; }
        }
    }