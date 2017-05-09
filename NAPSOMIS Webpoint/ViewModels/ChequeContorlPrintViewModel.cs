using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NAPSOMIS_Webpoint.ViewModels
    {
    public class ChequeContorlPrintViewModel
        {
        public DateTime receiptdate { get; set; }
        public string location { get; set; }
        public string cashier { get; set; }
        public string chequenumber { get; set; }

        public decimal amount { get; set; }
        }
    }