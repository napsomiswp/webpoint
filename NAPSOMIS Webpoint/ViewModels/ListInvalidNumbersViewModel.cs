using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace NAPSOMIS_Webpoint.ViewModels
    {
    public class ListInvalidNumbersViewModel
        {
        [Display(Name ="List By")]
        public string ListBy { get; set; }

         [Display(Name ="ERNo")]
        public string ferno { get; set; }

         [Display(Name ="Establishment")]
        public string EstablishmentName { get; set; }

         [Display(Name ="Begin Period")]
        public string BeginPeriod { get; set; }

         [Display(Name ="End Period")]
        public string EndPeriod { get; set; }

        }
    }