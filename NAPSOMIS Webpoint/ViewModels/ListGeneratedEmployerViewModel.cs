using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace NAPSOMIS_Webpoint.ViewModels
    {
    public class ListGeneratedEmployerViewModel
        {

        [Required(AllowEmptyStrings = false, ErrorMessage = "The ERNO is required!")]
        [Display(Name ="ERNO")]
        public string ferno { get; set; }

        [Display(Name ="Employer")]
        public string femp_name { get; set; }

       [Required(AllowEmptyStrings = false, ErrorMessage = "The From Date is required!")]
        public DateTime StartDate { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "The To Date is required!")]
        public DateTime EndDate { get; set; }

        }
    }