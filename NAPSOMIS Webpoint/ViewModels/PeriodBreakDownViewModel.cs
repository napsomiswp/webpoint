using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace NAPSOMIS_Webpoint.ViewModels
    {
    public class PeriodBreakDownViewModel
        {


        public int ID { get; set; }
        public string Period { get; set; }

        [Display(Name = "No. of Workers")]
        public int? NoOfWorkers { get; set; }

         [Display(Name = "Total Contribution")]
        public decimal? TotalContribution { get; set; }

        }
    }