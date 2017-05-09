using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace NAPSOMIS_Webpoint.ViewModels
    {
    public class ReversePaymentBreakdownViewModel
        {
        [Display(Name = "Code")]
        public string fcode { get; set; }

        [Display(Name = "Description")]
        public string fdesc { get; set; }

        [Display(Name = "Amount")]
        public decimal famount { get; set; }

        }
    }