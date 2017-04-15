using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace NAPSOMIS_Webpoint.ViewModels
    {
    public class EstablishmentDeactReactViewModel
        {
         [Display(Name ="ERNo")]  
        public string ferno { get; set; }

        [Display(Name ="Employer")]  
        public string femp_name { get; set; }

        [Display(Name ="Filter")]  
        public string fsearch { get; set; }

        [Display(Name ="Last Period")]  
        public string last_period { get; set; }

        [Display(Name ="Begin Period")]  
        public string begin_period { get; set; }

        [Display(Name ="Labour Force")] 
        public decimal? labour_force { get; set; }

        [Display(Name ="Contribution")]
        public decimal? contribution { get; set; }
  
        [Key]
        public int ID_SBTS { get; set; }
        }
    }