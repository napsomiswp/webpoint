using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NAPSOMIS_Webpoint.ViewModels
    {
    public class PaymentJournalPrintViewModel
        {
        public string receiptno { get; set; }
        public DateTime PaymentDate { get; set; }
        public string ferno { get; set; }
        public string establishment { get; set; }
        public decimal amount { get; set; }
        public string amountinwords { get; set; }
        public decimal creditamount { get; set; }
        public string journalno { get; set; }
        public string areaoffice { get; set; }
        public string cashier { get; set; }

        }
    }