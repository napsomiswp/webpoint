using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace NAPSOMIS_Webpoint.ViewModels
    {
    public class ReprintAckLetterViewModel
        {
        [Display(Name = "ERNo")]
        public string ferno { get; set; }

        [Display(Name = "Name of Establishment")]
        public string femp_name { get; set; }

        [Display(Name = "Filter (Begins with)")]
        public string fsearch { get; set; }
        }
    }