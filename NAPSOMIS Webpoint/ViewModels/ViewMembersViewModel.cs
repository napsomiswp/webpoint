using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NAPSOMIS_Webpoint.ViewModels
    {
    public class ViewMembersViewModel
        {
        public string ERNo { get; set; }
        public string Emp_Name { get; set; }
        public string Category { get; set; }

        public int? TotalNoofWorkers { get; set; }
        public decimal? TotalContribution { get; set; }

        }
    }