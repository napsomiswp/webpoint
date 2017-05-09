using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace NAPSOMIS_Webpoint.ViewModels
    {
    public class ListInvalidNumbersbyCategoryViewModel
        {

        [Display(Name ="List By")]
        public string ListBy { get; set; }

         [Display(Name ="ERNo")]
        public string ferno { get; set; }

         [Display(Name ="Establishment")]
        public string EstablishmentName { get; set; }

         [Display(Name ="Category")]
        public string fcat { get; set; }

         [Display(Name ="Begin Period")]
        public string BeginPeriod { get; set; }

         [Display(Name ="Staff Number")]
        public string StaffNumber { get; set; }

         [Display(Name ="Surname")]
        public string fsurname { get; set; }

         [Display(Name ="First Name")]
        public string firstname { get; set; }

         [Display(Name ="Other Name")]
        public string fothername { get; set; }


        }
    }

 