using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace NAPSOMIS_Webpoint.ViewModels
    {
    public class MCreditProListViewModel
        {

         [Display(Name = "ID")]
        public int ID { get; set; }

        [Display(Name = "Check")]
        public bool isChecked { get; set; }

        [Display(Name = "Period")]
        public string Period { get; set; }

         [Display(Name = "ERNO")]
        public string ERNO { get; set; }

        [Display(Name = "Establishment")]
        public string Establishment { get; set; }

        [Display(Name = "Type")]
        public string Type { get; set; }

        [Display(Name = "Contribution")]
        public decimal Contribution { get; set; }

        [Display(Name = "Contribution On File")]
        public decimal ContributionOnFile { get; set; }

        [Display(Name = "Amount Paid")]
        public decimal AmountPaid { get; set; }

        }
    }