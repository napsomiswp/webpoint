using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NAPSOMIS_Webpoint.ViewModels
    {
    public class ReceiveReportViewModel
        {
        
        [StringLength(25)]
        [Display(Name = "ERNo")]
        public string ferno { get; set; }
 
        [Display(Name = "Begin Date")]
        public DateTime fbegindate { get; set; }
 
        [Display(Name = "End Date")]
        public DateTime fenddate { get; set; }

        }
    }