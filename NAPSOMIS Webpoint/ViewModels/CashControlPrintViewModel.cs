using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NAPSOMIS_Webpoint.ViewModels
    {
    public class CashControlPrintViewModel
        {
        public DateTime receiptdate { get; set; }
        public string location { get; set; }
        public string cashier { get; set; }
        public string cashtype { get; set; }
        public string denomination { get; set; }
        public decimal number { get; set; }
        public decimal amount { get; set; }

        }
    }