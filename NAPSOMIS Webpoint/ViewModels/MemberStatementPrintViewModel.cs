using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NAPSOMIS_Webpoint.ViewModels
    {
    public class MemberStatementPrintViewModel
        {
        public string SSNo { get; set; }
        public string Type { get; set; } 
        public string NameofStaff { get; set; }
        public string ERNo { get; set; }
        public string NameOfEmployer { get; set; }
        public string sex { get; set; }
        public DateTime DateJoined { get; set; }
        public string StaffPINNo { get; set; }
        public string Month { get; set; }
        public decimal Contribution { get; set; }
        public decimal BackPay { get; set; }
        public decimal Salary { get; set; }
        public string DYear { get; set; }

        }
    }