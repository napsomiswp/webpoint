using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace NAPSOMIS_Webpoint.ViewModels
    {
    public class MemberStatementViewModel
        {

        [Display(Name = "Type of Report")]
        public string TypeofReport { get; set; }

        [Display(Name = "Est. Number")]
        public string ERNo { get; set; }

        [Display(Name = "Establishment")] 
        public string Emp_Name { get; set; }

        [Display(Name = "S.S. Number")]
        public string SSNo { get; set; }

        [Display(Name = "Name of Member")]
        public string NameOfMember { get; set; }

        [Display(Name = "Year")]
        [StringLength(4)]
        public string Year { get; set; }

        public bool PrintConsolidated { get; set; }

        }
    }