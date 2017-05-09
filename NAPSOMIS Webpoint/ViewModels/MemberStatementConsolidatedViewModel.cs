using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NAPSOMIS_Webpoint.ViewModels
    {
    public class MemberStatementConsolidatedViewModel
        {
        public string SSNo { get; set; }
        public string NameofStaff { get; set; }

        public string ActiveStatus { get; set; }
        public string PurchaseCreditMonths { get; set; }
        public string GrandFathingVAlidationMonths { get; set; }


        public string NameOfEmployers { get; set; }
        public string Sex { get; set; }
        public DateTime? DateJoined { get; set; }
       

        public string Year { get; set; }
        public int NoOfMonths { get; set; } 
        public decimal TotalContribution { get; set; } 
        public decimal TotalSalary { get; set; }
        
        }
    }

