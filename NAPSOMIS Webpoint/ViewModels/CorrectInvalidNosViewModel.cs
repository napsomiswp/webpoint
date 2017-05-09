using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace NAPSOMIS_Webpoint.ViewModels
    {
    public class CorrectInvalidNosViewModel
        {
        [Display(Name = "Valid Number")]
        public string validssno { get; set; }

        [Display(Name = "Fulll Name")]
        public string fname { get; set; }

        [Display(Name = "Use Type")]
        public string usetype { get; set; }

        [Display(Name = "ERNo")]
        public string ferno { get; set; }

        [Display(Name = "Establishment")]
        public string establishment { get; set; }

        [Display(Name = "Category")]
        public string fcat { get; set; }

        [Display(Name = "SSNo")]
        public string ssno { get; set; }

        [Display(Name = "Staff No")]
        public string staffno { get; set; }

        [Display(Name = "Surname")]
        public string fsurname { get; set; }

        [Display(Name = "Other Name(s)")]
        public string fothername { get; set; }

        [Display(Name = "First Name")]
        public string firstname { get; set; }


        }
    }