using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace NAPSOMIS_Webpoint.ViewModels
    {
    public class PaymentJournalViewModel
        {
        [Display(Name = "Est. No")]
        public string ferno { get; set; }

         [Display(Name = "Establishment")]
        public string festablishment { get; set; }

         [Display(Name = "Journal No")]
        public string fjournalno { get; set; }

         [Display(Name = "Receipt No")]
        public string freceiptno { get; set; }

         [Display(Name = "Receipt Date")]
        public DateTime? freceiptdate { get; set; }

         [Display(Name = "Payment Date")]
        public DateTime? fpaymentdate { get; set; }

         [Display(Name = "Amount")]
        public decimal? famount { get; set; }

         [Display(Name = "Bank")]
        public string fbank { get; set; }

         [Display(Name = "Branch")]
        public string fbranch { get; set; }

         [Display(Name = "Manual")]
         public bool fmanual { get; set; }

        }
    }