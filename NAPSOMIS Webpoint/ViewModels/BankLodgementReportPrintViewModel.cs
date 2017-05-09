using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NAPSOMIS_Webpoint.ViewModels
    {
    public class BankLodgementReportPrintViewModel
        {
         public DateTime receiptdate { get; set; }
        public string location { get; set; }
        public string cashier { get; set; }
        
        public decimal cash { get; set; }
        public decimal cheque { get; set; }
        public decimal bankadvice { get; set; }
        public decimal journaltransfer { get; set; }

         public decimal totalbankedbycashier { get; set; }
        public decimal totalcollectedbycashier { get; set; }
        public decimal totalbankedforday { get; set; }
        public decimal totalfortheday { get; set; }

        }
    }