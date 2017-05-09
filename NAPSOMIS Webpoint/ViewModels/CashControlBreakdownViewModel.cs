using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace NAPSOMIS_Webpoint.ViewModels
    {
    public class CashControlBreakdownViewModel
        {
        [Display(Name = "id")]
        public int id { get; set; }

        [Display(Name = "Denomination")]
        public string denomination { get; set; }

         [Display(Name = "Number")]
        public int number { get; set; }

         [Display(Name = "Amount")]
        public decimal amount { get; set; }

         [Display(Name = "Type")]
        public string type { get; set; }

        }
    }