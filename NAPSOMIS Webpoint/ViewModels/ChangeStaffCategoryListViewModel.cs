using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace NAPSOMIS_Webpoint.ViewModels
    {
    public class ChangeStaffCategoryListViewModel
        {

        public int recordid { get; set; }

        [Display(Name = "ERNo")]
        public string ferno { get; set; }

        [Display(Name = "Establishment")]
        public string establishment { get; set; }

        [Display(Name = "S.S. Number")]
        public string fssno { get; set; }

        [Display(Name = "Surname")]
        public string fsurname { get; set; }

        [Display(Name = "First Name")]
        public string firstname { get; set; }

        [Display(Name = "Other Name(s)")]
        public string fothername { get; set; }

        [Display(Name = "Period")]
        public string fperiod { get; set; }

        [Display(Name = "Current Category")]
        public string fcurrentcat { get; set; }

        [Display(Name = "Contribution")]
        public decimal? fcontribution { get; set; }

        }
    }