using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace NAPSOMIS_Webpoint.ViewModels
    {
    public class MemberCreditProcessingViewMode
        {
        [Display(Name = "Process All")]
        public bool? ProcessAll { get; set; }
        public int? TotalRecords { get; set; }
        }
    }