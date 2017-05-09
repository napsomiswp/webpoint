using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace NAPSOMIS_Webpoint.ViewModels
    {
    public class ChangeStaffCategoryViewModel
        {
         [Display(Name = "ID")]
        public string recordid { get; set; }

        [Display(Name = "ERNo")]
        public string ferno { get; set; }

        [Display(Name = "Establishment")]
        public string establishment { get; set; }

         [Display(Name = "Current Category")]
        public string fcurrentcat { get; set; }

         [Display(Name = "New Category")]
        public string fnewcat { get; set; }


         [Display(Name = "SSNo")]
        public string fssno { get; set; }

         [Display(Name = "Name")]
        public string fname { get; set; }

          [Display(Name = "Do this for all Members in this Category")]
        public bool fdothis { get; set; }

        }
    }