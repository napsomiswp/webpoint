using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace NAPSOMIS_Webpoint.ViewModels
    {
    public class ChequePaymentBreakdownViewModel
        {
         [Display(Name  = "Cheque No")]
        public string fChequeNo { get; set; }

        [Display(Name  = "Date")]
        public DateTime? fDate { get; set; }
 
         [Display(Name  = "Bank")]
        public string fBank { get; set; }

        [Display(Name  = "Branch")]
        public string fBranch { get; set; }

        [Display(Name  = "Amount")]
        public decimal? fAmount { get; set; }
 
        }
    }